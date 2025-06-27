using System;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_Project
{
    public partial class Form1 : Form
    {
        private const string KeyFileName = "key.key";
        private string keyFolderPath = string.Empty;
        private string logFilePath = string.Empty;
        private const string keyFileName = "key.key";
        private const string logFileName = "log.txt";


        public Form1()
        {
            InitializeComponent();
        }

        // Generate a random AES key
        private byte[] GenerateKey()
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.GenerateKey();
                return aes.Key;
            }
        }

        // Save key to file
        private void SaveKey(byte[] key)
        {
            string fullKeyPath = Path.Combine(keyFolderPath, keyFileName);
            File.WriteAllBytes(fullKeyPath, key);
        }

        // Load key from file
        private byte[] LoadKey()
        {
            string fullKeyPath = Path.Combine(keyFolderPath, keyFileName);
            return File.ReadAllBytes(fullKeyPath);
        }

        private void EncryptFile(string filePath, byte[] key)
        {
            byte[] iv;
            byte[] encrypted;

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.Key = key;
                aes.GenerateIV();
                iv = aes.IV;

                using (var encryptor = aes.CreateEncryptor())
                using (var ms = new MemoryStream())
                {
                    ms.Write(iv, 0, iv.Length);
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] data = File.ReadAllBytes(filePath);
                        cs.Write(data, 0, data.Length);
                    }
                    encrypted = ms.ToArray();
                }
            }

            File.WriteAllBytes(filePath, encrypted);
        }

        private void DecryptFile(string filePath, byte[] key)
        {
            byte[] fileData = File.ReadAllBytes(filePath);
            byte[] iv = new byte[16];
            Array.Copy(fileData, 0, iv, 0, iv.Length);
            byte[] encryptedData = new byte[fileData.Length - iv.Length];
            Array.Copy(fileData, iv.Length, encryptedData, 0, encryptedData.Length);

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.Key = key;
                aes.IV = iv;

                using (var decryptor = aes.CreateDecryptor())
                using (var ms = new MemoryStream())
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                {
                    cs.Write(encryptedData, 0, encryptedData.Length);
                    cs.FlushFinalBlock();
                    File.WriteAllBytes(filePath, ms.ToArray());
                }
            }
        }

        private void EncryptDirectory(string path, byte[] key)
        {
            foreach (string file in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
            {
                if (file.StartsWith(keyFolderPath)) continue; // Hindari enkripsi folder key
                try
                {
                    EncryptFile(file, key);
                    WriteLog($"Encrypted: {file}");
                }
                catch
                {
                    WriteLog($"Failed to encrypt: {file}");
                }
            }
        }

        private void DecryptDirectory(string path, byte[] key)
        {
            foreach (string file in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
            {
                if (file.StartsWith(keyFolderPath)) continue;
                try
                {
                    DecryptFile(file, key);
                    WriteLog($"Decrypted: {file}");
                }
                catch
                {
                    WriteLog($"Failed to decrypt: {file}");
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(keyFolderPath))
            {
                MessageBox.Show("Please select a folder to save keys and logs.", "Warning");
                return;
            }

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] key = File.Exists(Path.Combine(keyFolderPath, keyFileName)) ? LoadKey() : GenerateKey();
                if (!File.Exists(Path.Combine(keyFolderPath, keyFileName))) SaveKey(key);

                EncryptDirectory(folderBrowserDialog1.SelectedPath, key);
                lblStatus.Text = "Encryption completed";
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(keyFolderPath) || !File.Exists(Path.Combine(keyFolderPath, keyFileName)))
            {
                MessageBox.Show("Key not found or not selected.", "Error");
                return;
            }

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] key = LoadKey();
                DecryptDirectory(folderBrowserDialog1.SelectedPath, key);
                lblStatus.Text = "Decryption completed";
            }
        }

        private void btnSelectKeyDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                keyFolderPath = folderBrowserDialog1.SelectedPath;
                logFilePath = Path.Combine(keyFolderPath, logFileName);
                lblKeyLocation.Text = "Folder Key: " + keyFolderPath;
            }
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            string message =
    "Thank you for trying the live demo of this application\n\n" +
    "I hope you make a small donation for further development of the application by the developer and will be very grateful for it\n\n" +
    "Here you can send some BTC at this address:1ERMWVmhp1NLkH7JNdh2n3zLtSv7qKrwi8";

            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTerms_Click(object sender, EventArgs e)
        {
            string terms =
                "Software Usage Policy\n\n" +
                "1. The developer is not responsible for any damage to data or files that may occur as a result of using this application.\n\n" +
                "2. Misuse of this software for illegal actions, hacking, spreading malware, or unlawful purposes is strictly prohibited.\n\n" +
                "By using this application, you agree to the above policy.";

            MessageBox.Show(terms, "User's Policy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void WriteLog(string message)
        {
            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                sw.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
            }
        }
    }
}
