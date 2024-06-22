using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NET_L3_Zad1
{
    public partial class Form1 : Form
    {
        private readonly Stopwatch encryptionTimer = new Stopwatch();
        private readonly Stopwatch decryptionTimer = new Stopwatch();
        private SymmetricAlgorithm algorithm;

        public Form1()
        {
            InitializeComponent();

            // Dodaj algorytmy szyfrowania do ComboBox
            encryptionAlgorithmComboBox.Items.Add("AES");
            encryptionAlgorithmComboBox.Items.Add("DES");
            encryptionAlgorithmComboBox.Items.Add("TripleDES");

            encryptionAlgorithmComboBox.SelectedIndex = 0;
        }

        private void GenerateKeysButton_Click(object sender, EventArgs e)
        {
            // Inicjalizuj wybrany algorytm szyfrowania
            switch (encryptionAlgorithmComboBox.SelectedItem.ToString())
            {
                case "AES":
                    algorithm = Aes.Create();
                    break;
                case "DES":
                    algorithm = DES.Create();
                    break;
                case "TripleDES":
                    algorithm = TripleDES.Create();
                    break;
                default:
                    throw new ArgumentException("Invalid encryption algorithm selected");
            }

            algorithm.GenerateKey();
            algorithm.GenerateIV();

            // Wyświetl klucze i IV
            keyTextBox.Text = BitConverter.ToString(algorithm.Key);
            ivTextBox.Text = BitConverter.ToString(algorithm.IV);
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            // Zacznij mierzyć czas szyfrowania
            encryptionTimer.Restart();

            byte[] encryptedBytes;
            using (ICryptoTransform encryptor = algorithm.CreateEncryptor())
            {
                byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintextTextBox.Text);
                encryptedBytes = encryptor.TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);
            }

            // Zatrzymaj timer i wyświetl czas szyfrowania
            encryptionTimer.Stop();
            encryptionTimeLabel.Text = $"Encryption Time: {encryptionTimer.ElapsedMilliseconds} ms";

            // Wyświetl tekst zaszyfrowany w postaci ASCII i HEX
            encryptedASCIITextBox.Text = BitConverter.ToString(encryptedBytes);
            encryptedHexTextBox.Text = Convert.ToBase64String(encryptedBytes);
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            // Zacznij mierzyć czas deszyfrowania
            decryptionTimer.Restart();

            byte[] decryptedBytes;
            using (ICryptoTransform decryptor = algorithm.CreateDecryptor())
            {
                byte[] encryptedBytes = Convert.FromBase64String(encryptedHexTextBox.Text);
                decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
            }

            // Zatrzymaj timer i wyświetl czas deszyfrowania
            decryptionTimer.Stop();
            decryptionTimeLabel.Text = $"Decryption Time: {decryptionTimer.ElapsedMilliseconds} ms";

            // Wyświetl odszyfrowany tekst
            decryptedTextBox.Text = Encoding.UTF8.GetString(decryptedBytes);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

