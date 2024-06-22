using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace NET_L3_Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lokalizacja pliku do szyfrowania
            string inputFile = @"C:\Users\Latitude7490\Desktop\SEM4\Programowanie .NET - L\tajne_przez_poufne.txt";

            // Lokalizacja pliku wynikowego (zaszyfrowanego)
            string encryptedFile = @"C:\Users\Latitude7490\Desktop\SEM4\Programowanie .NET - L\tajne_przez_poufne_encrypted.txt";

            try
            {
                // Utworzenie nowej instancji RSACryptoServiceProvider
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    // Szyfrowanie pliku
                    RSAFileEncryptor.EncryptFile(inputFile, encryptedFile, rsa);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
