using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace NET_L3_Zad1
{
    public partial class Form1 : Form
    {
        private readonly Stopwatch encryptionTimer = new Stopwatch();
        private readonly Stopwatch decryptionTimer = new Stopwatch();
        private SymmetricAlgorithm algorithm;
        private long totalBytesProcessed;

        public Form1()
        {
            InitializeComponent();

            // Dodaj algorytmy szyfrowania do ComboBox
            encryptionAlgorithmComboBox.Items.Add("AES (CSP) 128 bit");
            encryptionAlgorithmComboBox.Items.Add("AES (CSP) 256 bit");
            encryptionAlgorithmComboBox.Items.Add("AES Managed 128 bit");
            encryptionAlgorithmComboBox.Items.Add("AES Managed 256 bit");
            encryptionAlgorithmComboBox.Items.Add("Rindael Managed 128 bit");
            encryptionAlgorithmComboBox.Items.Add("Rindael Managed 256 bit");
            encryptionAlgorithmComboBox.Items.Add("DES 56 bit");
            encryptionAlgorithmComboBox.Items.Add("3DES 168 bit");

            encryptionAlgorithmComboBox.SelectedIndex = 0;
        }

        private void GenerateKeysButton_Click(object sender, EventArgs e)
        {
            // Inicjalizuj wybrany algorytm szyfrowania
            switch (encryptionAlgorithmComboBox.SelectedItem.ToString())
            {
                case "AES (CSP) 128 bit":
                    algorithm = Aes.Create();
                    break;
                case "AES (CSP) 256 bit":
                    algorithm = Aes.Create();
                    algorithm.KeySize = 256;
                    break;
                case "AES Managed 128 bit":
                    algorithm = Aes.Create();
                    break;
                case "AES Managed 256 bit":
                    algorithm = Aes.Create();
                    algorithm.KeySize = 256;
                    break;
                case "Rindael Managed 128 bit":
                    algorithm = Rijndael.Create();
                    break;
                case "Rindael Managed 256 bit":
                    algorithm = Rijndael.Create();
                    algorithm.KeySize = 256;
                    break;
                case "DES 56 bit":
                    algorithm = DES.Create();
                    break;
                case "3DES 168 bit":
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
            totalBytesProcessed = 0;

            byte[] encryptedBytes;
            using (ICryptoTransform encryptor = algorithm.CreateEncryptor())
            {
                byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintextTextBox.Text);
                encryptedBytes = encryptor.TransformFinalBlock(plaintextBytes, 0, plaintextBytes.Length);
                totalBytesProcessed += encryptedBytes.Length;
            }

            // Zatrzymaj timer i wyświetl czas szyfrowania
            encryptionTimer.Stop();
            double encryptionTime = encryptionTimer.Elapsed.TotalSeconds;

            // Wyświetl tekst zaszyfrowany w postaci ASCII i HEX
            encryptedASCIITextBox.Text = BitConverter.ToString(encryptedBytes);
            encryptedHexTextBox.Text = Convert.ToBase64String(encryptedBytes);

            // Oblicz szybkość przetwarzania danych
            double bytesPerSecondRAM = totalBytesProcessed / encryptionTime;
            double bytesPerSecondHDD = totalBytesProcessed / (encryptionTime + SimulateDiskAccessTime());
            double secondsPerBlock = encryptionTime / (totalBytesProcessed / algorithm.BlockSize);

            // Aktualizuj etykiety z wynikami
            encryptionTimeLabel.Text = $"Encryption Time (s/block): {secondsPerBlock:F6} s/block";
            encryptionSpeedRAMLabel.Text = $"Encryption Speed (RAM): {bytesPerSecondRAM:F2} bytes/s";
            encryptionSpeedHDDLabel.Text = $"Encryption Speed (HDD): {bytesPerSecondHDD:F2} bytes/s";
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            // Zacznij mierzyć czas deszyfrowania
            decryptionTimer.Restart();
            totalBytesProcessed = 0;

            byte[] decryptedBytes;
            using (ICryptoTransform decryptor = algorithm.CreateDecryptor())
            {
                byte[] encryptedBytes = Convert.FromBase64String(encryptedHexTextBox.Text);
                decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                totalBytesProcessed += decryptedBytes.Length;
            }

            // Zatrzymaj timer i wyświetl czas deszyfrowania
            decryptionTimer.Stop();
            double decryptionTime = decryptionTimer.Elapsed.TotalSeconds;

            // Wyświetl odszyfrowany tekst
            decryptedTextBox.Text = Encoding.UTF8.GetString(decryptedBytes);

            // Oblicz szybkość przetwarzania danych
            double bytesPerSecondRAM = totalBytesProcessed / decryptionTime;
            double bytesPerSecondHDD = totalBytesProcessed / (decryptionTime + SimulateDiskAccessTime());
            double secondsPerBlock = decryptionTime / (totalBytesProcessed / algorithm.BlockSize);

            // Aktualizuj etykiety z wynikami
            decryptionTimeLabel.Text = $"Decryption Time (s/block): {secondsPerBlock:F6} s/block";
            decryptionSpeedRAMLabel.Text = $"Decryption Speed (RAM): {bytesPerSecondRAM:F2} bytes/s";
            decryptionSpeedHDDLabel.Text = $"Decryption Speed (HDD): {bytesPerSecondHDD:F2} bytes/s";
        }

        private double SimulateDiskAccessTime()
        {
            // Symuluj czas dostępu do dysku (w sekundach)
            return 0.01; // 10 ms
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
