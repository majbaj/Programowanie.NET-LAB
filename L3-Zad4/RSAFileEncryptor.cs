using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NET_L3_Zad4
{
    public class RSAFileEncryptor
    {
        // Metoda do szyfrowania pliku przy użyciu klucza RSA
        public static void EncryptFile(string inputFile, string outputFile, RSACryptoServiceProvider rsaProvider)
        {
            try
            {
                // Odczytanie danych z pliku wejściowego
                byte[] dataToEncrypt = File.ReadAllBytes(inputFile);

                // Szyfrowanie danych
                byte[] encryptedData = rsaProvider.Encrypt(dataToEncrypt, false);

                // Zapisanie zaszyfrowanych danych do pliku wyjściowego
                File.WriteAllBytes(outputFile, encryptedData);

                Console.WriteLine("Plik został zaszyfrowany i zapisany jako: " + outputFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd podczas szyfrowania pliku: " + ex.Message);
            }
        }
    }
}
