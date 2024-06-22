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
            this.decryptionTimeLabel = new System.Windows.Forms.Label();
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
            this.keyTextBox.Location = new System.Drawing.Point(104, 263);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.ReadOnly = true;
            this.keyTextBox.Size = new System.Drawing.Size(684, 50);
            this.keyTextBox.TabIndex = 5;
            // 
            // ivTextBox
            // 
            this.ivTextBox.Location = new System.Drawing.Point(104, 319);
            this.ivTextBox.Multiline = true;
            this.ivTextBox.Name = "ivTextBox";
            this.ivTextBox.ReadOnly = true;
            this.ivTextBox.Size = new System.Drawing.Size(684, 50);
            this.ivTextBox.TabIndex = 6;
            // 
            // GenerateKeysButton
            // 
            this.GenerateKeysButton.Location = new System.Drawing.Point(139, 10);
            this.GenerateKeysButton.Name = "GenerateKeysButton";
            this.GenerateKeysButton.Size = new System.Drawing.Size(227, 23);
            this.GenerateKeysButton.TabIndex = 7;
            this.GenerateKeysButton.Text = "Generate Keys and IV";
            this.GenerateKeysButton.UseVisualStyleBackColor = true;
            this.GenerateKeysButton.Click += new System.EventHandler(this.GenerateKeysButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(380, 10);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 8;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(472, 10);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 9;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // encryptionTimeLabel
            // 
            this.encryptionTimeLabel.AutoSize = true;
            this.encryptionTimeLabel.Location = new System.Drawing.Point(12, 372);
            this.encryptionTimeLabel.Name = "encryptionTimeLabel";
            this.encryptionTimeLabel.Size = new System.Drawing.Size(86, 13);
            this.encryptionTimeLabel.TabIndex = 10;
            this.encryptionTimeLabel.Text = "Encryption Time:";
            // 
            // decryptionTimeLabel
            // 
            this.decryptionTimeLabel.AutoSize = true;
            this.decryptionTimeLabel.Location = new System.Drawing.Point(12, 395);
            this.decryptionTimeLabel.Name = "decryptionTimeLabel";
            this.decryptionTimeLabel.Size = new System.Drawing.Size(87, 13);
            this.decryptionTimeLabel.TabIndex = 11;
            this.decryptionTimeLabel.Text = "Decryption Time:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 42);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 13);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Insert text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Encrypted ASCII";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Encrypted HEX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Decrypted text";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "KEY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "IV";
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
            this.Controls.Add(this.decryptionTimeLabel);
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
        private System.Windows.Forms.Label decryptionTimeLabel;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
    }
}