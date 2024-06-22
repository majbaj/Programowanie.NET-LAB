namespace NET_L3_Zad1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.encryptionAlgorithmComboBox = new System.Windows.Forms.ComboBox();
            this.plaintextTextBox = new System.Windows.Forms.TextBox();
            this.encryptedASCIITextBox = new System.Windows.Forms.TextBox();
            this.encryptedHexTextBox = new System.Windows.Forms.TextBox();
            this.decryptedTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.ivTextBox = new System.Windows.Forms.TextBox();
            this.GenerateKeysButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.encryptionTimeLabel = new System.Windows.Forms.Label();
            this.encryptionSpeedRAMLabel = new System.Windows.Forms.Label();
            this.encryptionSpeedHDDLabel = new System.Windows.Forms.Label();
            this.decryptionTimeLabel = new System.Windows.Forms.Label();
            this.decryptionSpeedRAMLabel = new System.Windows.Forms.Label();
            this.decryptionSpeedHDDLabel = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encryptionAlgorithmComboBox
            // 
            this.encryptionAlgorithmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encryptionAlgorithmComboBox.FormattingEnabled = true;
            this.encryptionAlgorithmComboBox.Location = new System.Drawing.Point(12, 12);
            this.encryptionAlgorithmComboBox.Name = "encryptionAlgorithmComboBox";
            this.encryptionAlgorithmComboBox.Size = new System.Drawing.Size(121, 21);
            this.encryptionAlgorithmComboBox.TabIndex = 0;
            // 
            // plaintextTextBox
            // 
            this.plaintextTextBox.Location = new System.Drawing.Point(96, 39);
            this.plaintextTextBox.Multiline = true;
            this.plaintextTextBox.Name = "plaintextTextBox";
            this.plaintextTextBox.Size = new System.Drawing.Size(692, 50);
            this.plaintextTextBox.TabIndex = 1;
            // 
            // encryptedASCIITextBox
            // 
            this.encryptedASCIITextBox.Location = new System.Drawing.Point(96, 95);
            this.encryptedASCIITextBox.Multiline = true;
            this.encryptedASCIITextBox.Name = "encryptedASCIITextBox";
            this.encryptedASCIITextBox.ReadOnly = true;
            this.encryptedASCIITextBox.Size = new System.Drawing.Size(692, 50);
            this.encryptedASCIITextBox.TabIndex = 2;
            // 
            // encryptedHexTextBox
            // 
            this.encryptedHexTextBox.Location = new System.Drawing.Point(96, 151);
            this.encryptedHexTextBox.Multiline = true;
            this.encryptedHexTextBox.Name = "encryptedHexTextBox";
            this.encryptedHexTextBox.ReadOnly = true;
            this.encryptedHexTextBox.Size = new System.Drawing.Size(692, 50);
            this.encryptedHexTextBox.TabIndex = 3;
            // 
            // decryptedTextBox
            // 
            this.decryptedTextBox.Location = new System.Drawing.Point(96, 207);
            this.decryptedTextBox.Multiline = true;
            this.decryptedTextBox.Name = "decryptedTextBox";
            this.decryptedTextBox.ReadOnly = true;
            this.decryptedTextBox.Size = new System.Drawing.Size(692, 50);
            this.decryptedTextBox.TabIndex = 4;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(96, 263);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.ReadOnly = true;
            this.keyTextBox.Size = new System.Drawing.Size(692, 50);
            this.keyTextBox.TabIndex = 5;
            // 
            // ivTextBox
            // 
            this.ivTextBox.Location = new System.Drawing.Point(96, 319);
            this.ivTextBox.Multiline = true;
            this.ivTextBox.Name = "ivTextBox";
            this.ivTextBox.ReadOnly = true;
            this.ivTextBox.Size = new System.Drawing.Size(692, 50);
            this.ivTextBox.TabIndex = 6;
            // 
            // GenerateKeysButton
            // 
            this.GenerateKeysButton.Location = new System.Drawing.Point(139, 12);
            this.GenerateKeysButton.Name = "GenerateKeysButton";
            this.GenerateKeysButton.Size = new System.Drawing.Size(75, 21);
            this.GenerateKeysButton.TabIndex = 7;
            this.GenerateKeysButton.Text = "Generate Keys";
            this.GenerateKeysButton.UseVisualStyleBackColor = true;
            this.GenerateKeysButton.Click += new System.EventHandler(this.GenerateKeysButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(220, 12);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 21);
            this.EncryptButton.TabIndex = 8;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(301, 12);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 21);
            this.DecryptButton.TabIndex = 9;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // encryptionTimeLabel
            // 
            this.encryptionTimeLabel.AutoSize = true;
            this.encryptionTimeLabel.Location = new System.Drawing.Point(12, 375);
            this.encryptionTimeLabel.Name = "encryptionTimeLabel";
            this.encryptionTimeLabel.Size = new System.Drawing.Size(100, 13);
            this.encryptionTimeLabel.TabIndex = 10;
            this.encryptionTimeLabel.Text = "Encryption Time (s):";
            // 
            // encryptionSpeedRAMLabel
            // 
            this.encryptionSpeedRAMLabel.AutoSize = true;
            this.encryptionSpeedRAMLabel.Location = new System.Drawing.Point(12, 398);
            this.encryptionSpeedRAMLabel.Name = "encryptionSpeedRAMLabel";
            this.encryptionSpeedRAMLabel.Size = new System.Drawing.Size(141, 13);
            this.encryptionSpeedRAMLabel.TabIndex = 11;
            this.encryptionSpeedRAMLabel.Text = "Encryption Speed RAM (B/s):";
            // 
            // encryptionSpeedHDDLabel
            // 
            this.encryptionSpeedHDDLabel.AutoSize = true;
            this.encryptionSpeedHDDLabel.Location = new System.Drawing.Point(12, 421);
            this.encryptionSpeedHDDLabel.Name = "encryptionSpeedHDDLabel";
            this.encryptionSpeedHDDLabel.Size = new System.Drawing.Size(140, 13);
            this.encryptionSpeedHDDLabel.TabIndex = 12;
            this.encryptionSpeedHDDLabel.Text = "Encryption Speed HDD (B/s):";
            // 
            // decryptionTimeLabel
            // 
            this.decryptionTimeLabel.AutoSize = true;
            this.decryptionTimeLabel.Location = new System.Drawing.Point(382, 375);
            this.decryptionTimeLabel.Name = "decryptionTimeLabel";
            this.decryptionTimeLabel.Size = new System.Drawing.Size(100, 13);
            this.decryptionTimeLabel.TabIndex = 13;
            this.decryptionTimeLabel.Text = "Decryption Time (s):";
            // 
            // decryptionSpeedRAMLabel
            // 
            this.decryptionSpeedRAMLabel.AutoSize = true;
            this.decryptionSpeedRAMLabel.Location = new System.Drawing.Point(382, 398);
            this.decryptionSpeedRAMLabel.Name = "decryptionSpeedRAMLabel";
            this.decryptionSpeedRAMLabel.Size = new System.Drawing.Size(141, 13);
            this.decryptionSpeedRAMLabel.TabIndex = 14;
            this.decryptionSpeedRAMLabel.Text = "Decryption Speed RAM (B/s):";
            // 
            // decryptionSpeedHDDLabel
            // 
            this.decryptionSpeedHDDLabel.AutoSize = true;
            this.decryptionSpeedHDDLabel.Location = new System.Drawing.Point(382, 421);
            this.decryptionSpeedHDDLabel.Name = "decryptionSpeedHDDLabel";
            this.decryptionSpeedHDDLabel.Size = new System.Drawing.Size(140, 13);
            this.decryptionSpeedHDDLabel.TabIndex = 15;
            this.decryptionSpeedHDDLabel.Text = "Decryption Speed HDD (B/s):";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 39);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 13);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Plaintext:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Encrypted (ASCII):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Encrypted (Hex):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Decrypted:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Key:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "IV:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.decryptionSpeedHDDLabel);
            this.Controls.Add(this.decryptionSpeedRAMLabel);
            this.Controls.Add(this.decryptionTimeLabel);
            this.Controls.Add(this.encryptionSpeedHDDLabel);
            this.Controls.Add(this.encryptionSpeedRAMLabel);
            this.Controls.Add(this.encryptionTimeLabel);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.GenerateKeysButton);
            this.Controls.Add(this.ivTextBox);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.decryptedTextBox);
            this.Controls.Add(this.encryptedHexTextBox);
            this.Controls.Add(this.encryptedASCIITextBox);
            this.Controls.Add(this.plaintextTextBox);
            this.Controls.Add(this.encryptionAlgorithmComboBox);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox encryptionAlgorithmComboBox;
        private System.Windows.Forms.TextBox plaintextTextBox;
        private System.Windows.Forms.TextBox encryptedASCIITextBox;
        private System.Windows.Forms.TextBox encryptedHexTextBox;
        private System.Windows.Forms.TextBox decryptedTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.TextBox ivTextBox;
        private System.Windows.Forms.Button GenerateKeysButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label encryptionTimeLabel;
        private System.Windows.Forms.Label encryptionSpeedRAMLabel;
        private System.Windows.Forms.Label encryptionSpeedHDDLabel;
        private System.Windows.Forms.Label decryptionTimeLabel;
        private System.Windows.Forms.Label decryptionSpeedRAMLabel;
        private System.Windows.Forms.Label decryptionSpeedHDDLabel;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
