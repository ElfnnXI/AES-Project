namespace AES_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSelectKeyDir = new System.Windows.Forms.Button();
            this.lblKeyLocation = new System.Windows.Forms.Label();
            this.btnDonate = new System.Windows.Forms.Button();
            this.btnTerms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEncrypt.Location = new System.Drawing.Point(17, 347);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(402, 60);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encryption";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDecrypt.Location = new System.Drawing.Point(17, 413);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(402, 60);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Decryption";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.GreenYellow;
            this.lblStatus.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(9, 19);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(115, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status: Idle";
            // 
            // btnSelectKeyDir
            // 
            this.btnSelectKeyDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSelectKeyDir.Location = new System.Drawing.Point(12, 479);
            this.btnSelectKeyDir.Name = "btnSelectKeyDir";
            this.btnSelectKeyDir.Size = new System.Drawing.Size(820, 60);
            this.btnSelectKeyDir.TabIndex = 3;
            this.btnSelectKeyDir.Text = "Save Key";
            this.btnSelectKeyDir.UseVisualStyleBackColor = false;
            this.btnSelectKeyDir.Click += new System.EventHandler(this.btnSelectKeyDir_Click);
            // 
            // lblKeyLocation
            // 
            this.lblKeyLocation.AutoSize = true;
            this.lblKeyLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblKeyLocation.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyLocation.Location = new System.Drawing.Point(14, 319);
            this.lblKeyLocation.Name = "lblKeyLocation";
            this.lblKeyLocation.Size = new System.Drawing.Size(511, 13);
            this.lblKeyLocation.TabIndex = 4;
            this.lblKeyLocation.Text = "* Location Key: Log and key storage locations have not been set";
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDonate.Location = new System.Drawing.Point(430, 347);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(402, 60);
            this.btnDonate.TabIndex = 5;
            this.btnDonate.Text = "Donate";
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // btnTerms
            // 
            this.btnTerms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTerms.Location = new System.Drawing.Point(430, 413);
            this.btnTerms.Name = "btnTerms";
            this.btnTerms.Size = new System.Drawing.Size(402, 60);
            this.btnTerms.TabIndex = 6;
            this.btnTerms.Text = "Software Usage Policy";
            this.btnTerms.UseVisualStyleBackColor = false;
            this.btnTerms.Click += new System.EventHandler(this.btnTerms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.btnTerms);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.lblKeyLocation);
            this.Controls.Add(this.btnSelectKeyDir);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Encryption Standard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSelectKeyDir;
        private System.Windows.Forms.Label lblKeyLocation;
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.Button btnTerms;
    }
}

