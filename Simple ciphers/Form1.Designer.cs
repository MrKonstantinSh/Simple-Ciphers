namespace Simple_ciphers
{
    partial class fMain
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
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.rbRotatingSquare = new System.Windows.Forms.RadioButton();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.rbRailFence = new System.Windows.Forms.RadioButton();
            this.lblEncryptDecryptMethod = new System.Windows.Forms.Label();
            this.cbUseDataInRcb = new System.Windows.Forms.CheckBox();
            this.rtbResText = new System.Windows.Forms.RichTextBox();
            this.lblResText = new System.Windows.Forms.Label();
            this.lblSrcText = new System.Windows.Forms.Label();
            this.rtbSrcText = new System.Windows.Forms.RichTextBox();
            this.btnChoosePathToResFile = new System.Windows.Forms.Button();
            this.tbPathToResFile = new System.Windows.Forms.TextBox();
            this.lblPathToResFile = new System.Windows.Forms.Label();
            this.btnChoosePathToSrcFile = new System.Windows.Forms.Button();
            this.tbPathToSrcFile = new System.Windows.Forms.TextBox();
            this.lblPathToSrcFile = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.rbRotatingSquare);
            this.gbMain.Controls.Add(this.btnDecrypt);
            this.gbMain.Controls.Add(this.btnEncrypt);
            this.gbMain.Controls.Add(this.rbRailFence);
            this.gbMain.Controls.Add(this.lblEncryptDecryptMethod);
            this.gbMain.Controls.Add(this.cbUseDataInRcb);
            this.gbMain.Controls.Add(this.rtbResText);
            this.gbMain.Controls.Add(this.lblResText);
            this.gbMain.Controls.Add(this.lblSrcText);
            this.gbMain.Controls.Add(this.rtbSrcText);
            this.gbMain.Controls.Add(this.btnChoosePathToResFile);
            this.gbMain.Controls.Add(this.tbPathToResFile);
            this.gbMain.Controls.Add(this.lblPathToResFile);
            this.gbMain.Controls.Add(this.btnChoosePathToSrcFile);
            this.gbMain.Controls.Add(this.tbPathToSrcFile);
            this.gbMain.Controls.Add(this.lblPathToSrcFile);
            this.gbMain.Controls.Add(this.lblKey);
            this.gbMain.Controls.Add(this.tbKey);
            this.gbMain.Location = new System.Drawing.Point(16, 15);
            this.gbMain.Margin = new System.Windows.Forms.Padding(4);
            this.gbMain.Name = "gbMain";
            this.gbMain.Padding = new System.Windows.Forms.Padding(4);
            this.gbMain.Size = new System.Drawing.Size(519, 764);
            this.gbMain.TabIndex = 3;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Encrypt/Decrypt";
            // 
            // rbRotatingSquare
            // 
            this.rbRotatingSquare.AutoSize = true;
            this.rbRotatingSquare.Location = new System.Drawing.Point(117, 683);
            this.rbRotatingSquare.Margin = new System.Windows.Forms.Padding(4);
            this.rbRotatingSquare.Name = "rbRotatingSquare";
            this.rbRotatingSquare.Size = new System.Drawing.Size(130, 21);
            this.rbRotatingSquare.TabIndex = 16;
            this.rbRotatingSquare.Text = "Rotating square";
            this.rbRotatingSquare.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(132, 718);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(107, 31);
            this.btnDecrypt.TabIndex = 15;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(17, 718);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(107, 31);
            this.btnEncrypt.TabIndex = 14;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // rbRailFence
            // 
            this.rbRailFence.AutoSize = true;
            this.rbRailFence.Checked = true;
            this.rbRailFence.Location = new System.Drawing.Point(17, 683);
            this.rbRailFence.Margin = new System.Windows.Forms.Padding(4);
            this.rbRailFence.Name = "rbRailFence";
            this.rbRailFence.Size = new System.Drawing.Size(92, 21);
            this.rbRailFence.TabIndex = 13;
            this.rbRailFence.TabStop = true;
            this.rbRailFence.Text = "Rail fence";
            this.rbRailFence.UseVisualStyleBackColor = true;
            // 
            // lblEncryptDecryptMethod
            // 
            this.lblEncryptDecryptMethod.AutoSize = true;
            this.lblEncryptDecryptMethod.BackColor = System.Drawing.Color.Transparent;
            this.lblEncryptDecryptMethod.Location = new System.Drawing.Point(13, 660);
            this.lblEncryptDecryptMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncryptDecryptMethod.Name = "lblEncryptDecryptMethod";
            this.lblEncryptDecryptMethod.Size = new System.Drawing.Size(202, 17);
            this.lblEncryptDecryptMethod.TabIndex = 12;
            this.lblEncryptDecryptMethod.Text = "Encryption/Decryption Method:";
            // 
            // cbUseDataInRcb
            // 
            this.cbUseDataInRcb.AutoSize = true;
            this.cbUseDataInRcb.Checked = true;
            this.cbUseDataInRcb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseDataInRcb.Location = new System.Drawing.Point(17, 623);
            this.cbUseDataInRcb.Margin = new System.Windows.Forms.Padding(4);
            this.cbUseDataInRcb.Name = "cbUseDataInRcb";
            this.cbUseDataInRcb.Size = new System.Drawing.Size(306, 21);
            this.cbUseDataInRcb.TabIndex = 11;
            this.cbUseDataInRcb.Text = "Encrypt/Decrypt text entered in the program";
            this.cbUseDataInRcb.UseVisualStyleBackColor = true;
            // 
            // rtbResText
            // 
            this.rtbResText.Location = new System.Drawing.Point(17, 431);
            this.rtbResText.Margin = new System.Windows.Forms.Padding(4);
            this.rtbResText.Name = "rtbResText";
            this.rtbResText.ReadOnly = true;
            this.rtbResText.Size = new System.Drawing.Size(479, 184);
            this.rtbResText.TabIndex = 9;
            this.rtbResText.Text = "";
            // 
            // lblResText
            // 
            this.lblResText.AutoSize = true;
            this.lblResText.BackColor = System.Drawing.Color.Transparent;
            this.lblResText.Location = new System.Drawing.Point(13, 411);
            this.lblResText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResText.Name = "lblResText";
            this.lblResText.Size = new System.Drawing.Size(190, 17);
            this.lblResText.TabIndex = 10;
            this.lblResText.Text = "Encryption/Decryption result:";
            // 
            // lblSrcText
            // 
            this.lblSrcText.AutoSize = true;
            this.lblSrcText.BackColor = System.Drawing.Color.Transparent;
            this.lblSrcText.Location = new System.Drawing.Point(13, 197);
            this.lblSrcText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSrcText.Name = "lblSrcText";
            this.lblSrcText.Size = new System.Drawing.Size(209, 17);
            this.lblSrcText.TabIndex = 9;
            this.lblSrcText.Text = "Text to be encrypted/decrypted:";
            // 
            // rtbSrcText
            // 
            this.rtbSrcText.Location = new System.Drawing.Point(17, 217);
            this.rtbSrcText.Margin = new System.Windows.Forms.Padding(4);
            this.rtbSrcText.Name = "rtbSrcText";
            this.rtbSrcText.Size = new System.Drawing.Size(479, 184);
            this.rtbSrcText.TabIndex = 8;
            this.rtbSrcText.Text = "";
            // 
            // btnChoosePathToResFile
            // 
            this.btnChoosePathToResFile.Location = new System.Drawing.Point(397, 155);
            this.btnChoosePathToResFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoosePathToResFile.Name = "btnChoosePathToResFile";
            this.btnChoosePathToResFile.Size = new System.Drawing.Size(100, 27);
            this.btnChoosePathToResFile.TabIndex = 7;
            this.btnChoosePathToResFile.Text = "Browse...";
            this.btnChoosePathToResFile.UseVisualStyleBackColor = true;
            this.btnChoosePathToResFile.Click += new System.EventHandler(this.BtnChoosePathToResFile_Click);
            // 
            // tbPathToResFile
            // 
            this.tbPathToResFile.Location = new System.Drawing.Point(17, 156);
            this.tbPathToResFile.Margin = new System.Windows.Forms.Padding(4);
            this.tbPathToResFile.Name = "tbPathToResFile";
            this.tbPathToResFile.ReadOnly = true;
            this.tbPathToResFile.Size = new System.Drawing.Size(371, 22);
            this.tbPathToResFile.TabIndex = 6;
            // 
            // lblPathToResFile
            // 
            this.lblPathToResFile.AutoSize = true;
            this.lblPathToResFile.BackColor = System.Drawing.Color.Transparent;
            this.lblPathToResFile.Location = new System.Drawing.Point(13, 137);
            this.lblPathToResFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPathToResFile.Name = "lblPathToResFile";
            this.lblPathToResFile.Size = new System.Drawing.Size(288, 17);
            this.lblPathToResFile.TabIndex = 5;
            this.lblPathToResFile.Text = "The path to the encryption/decryption result:";
            // 
            // btnChoosePathToSrcFile
            // 
            this.btnChoosePathToSrcFile.Location = new System.Drawing.Point(397, 101);
            this.btnChoosePathToSrcFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoosePathToSrcFile.Name = "btnChoosePathToSrcFile";
            this.btnChoosePathToSrcFile.Size = new System.Drawing.Size(100, 27);
            this.btnChoosePathToSrcFile.TabIndex = 4;
            this.btnChoosePathToSrcFile.Text = "Browse...";
            this.btnChoosePathToSrcFile.UseVisualStyleBackColor = true;
            this.btnChoosePathToSrcFile.Click += new System.EventHandler(this.BtnChoosePathToSrcFile_Click);
            // 
            // tbPathToSrcFile
            // 
            this.tbPathToSrcFile.Location = new System.Drawing.Point(17, 102);
            this.tbPathToSrcFile.Margin = new System.Windows.Forms.Padding(4);
            this.tbPathToSrcFile.Name = "tbPathToSrcFile";
            this.tbPathToSrcFile.ReadOnly = true;
            this.tbPathToSrcFile.Size = new System.Drawing.Size(371, 22);
            this.tbPathToSrcFile.TabIndex = 3;
            // 
            // lblPathToSrcFile
            // 
            this.lblPathToSrcFile.AutoSize = true;
            this.lblPathToSrcFile.BackColor = System.Drawing.Color.Transparent;
            this.lblPathToSrcFile.Location = new System.Drawing.Point(13, 82);
            this.lblPathToSrcFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPathToSrcFile.Name = "lblPathToSrcFile";
            this.lblPathToSrcFile.Size = new System.Drawing.Size(321, 17);
            this.lblPathToSrcFile.TabIndex = 2;
            this.lblPathToSrcFile.Text = "The path to the file with the source text/ciphertext:";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(13, 28);
            this.lblKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(36, 17);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "Key:";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(17, 48);
            this.tbKey.Margin = new System.Windows.Forms.Padding(4);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(479, 22);
            this.tbKey.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 794);
            this.Controls.Add(this.gbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Chipers";
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.RadioButton rbRailFence;
        private System.Windows.Forms.Label lblEncryptDecryptMethod;
        private System.Windows.Forms.CheckBox cbUseDataInRcb;
        private System.Windows.Forms.RichTextBox rtbResText;
        private System.Windows.Forms.Label lblResText;
        private System.Windows.Forms.Label lblSrcText;
        private System.Windows.Forms.RichTextBox rtbSrcText;
        private System.Windows.Forms.Button btnChoosePathToResFile;
        private System.Windows.Forms.TextBox tbPathToResFile;
        private System.Windows.Forms.Label lblPathToResFile;
        private System.Windows.Forms.Button btnChoosePathToSrcFile;
        private System.Windows.Forms.TextBox tbPathToSrcFile;
        private System.Windows.Forms.Label lblPathToSrcFile;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RadioButton rbRotatingSquare;
    }
}

