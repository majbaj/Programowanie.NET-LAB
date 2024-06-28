using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EncryptionApp
{
    public partial class Form1 : Form
    {
        private EncryptionService _encryptionService;
        private Configuration _configuration;

        public Form1()
        {
            InitializeComponent();
            _encryptionService = new EncryptionService();
            _configuration = new Configuration();
        }

        private async void btnEncrypt_Click(object sender, EventArgs e)
        {
            var files = GetFilesToProcess();
            foreach (var file in files)
            {
                try
                {
                    var encryptedFilePath = await Task.Run(() => _encryptionService.EncryptFile(file, _configuration));
                    var encryptedData = File.ReadAllBytes(encryptedFilePath);
                    await Task.Run(() => Uploader.UploadFileAsync(encryptedData, Path.GetFileName(encryptedFilePath)));
                    MessageBox.Show($"File {file} encrypted and uploaded successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error encrypting file {file}: {ex.Message}");
                }
            }
        }

        private async void btnDecrypt_Click(object sender, EventArgs e)
        {
            var files = GetFilesToProcess();
            foreach (var file in files)
            {
                try
                {
                    var decryptedFilePath = await Task.Run(() => _encryptionService.DecryptFile(file, _configuration));
                    var decryptedData = File.ReadAllBytes(decryptedFilePath);
                    await Task.Run(() => Uploader.UploadFileAsync(decryptedData, Path.GetFileName(decryptedFilePath)));
                    MessageBox.Show($"File {file} decrypted and uploaded successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error decrypting file {file}: {ex.Message}");
                }
            }
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lstFiles.Items.Clear();
                foreach (var file in openFileDialog.FileNames)
                {
                    lstFiles.Items.Add(file);
                }
            }
        }

        private string[] GetFilesToProcess()
        {
            var files = new string[lstFiles.Items.Count];
            lstFiles.Items.CopyTo(files, 0);
            return files;
        }
    }
}
