using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main()
    {
        // Encrypted ciphertext in hexadecimal
        string ciphertextHex = "23c73dde8faedd91413fb5dd1d7e066d70425ed1e058d0e2f7e9e43501824a95446baf28f6ce7ffd3c544f40efb5c80f235de1321214328781a6ea0c0c4c7b74be3968ca1ffb8455";

        // Convert ciphertext from hexadecimal to byte array
        byte[] ciphertext = HexStringToByteArray(ciphertextHex);

        // Iterate over all possible keys (6 bytes with last 4 bytes as '5')
        for (int b1 = 0; b1 <= 255; b1++)
        {
            for (int b2 = 0; b2 <= 255; b2++)
            {
                for (int b3 = 0; b3 <= 255; b3++)
                {
                    // Create potential key bytes
                    byte[] key = { (byte)b1, (byte)b2, (byte)b3, 0x35, 0x35, 0x35 };

                    // Decrypt using DES
                    string decryptedText = DecryptDES(ciphertext, key);

                    // Check if decrypted text starts with "test"
                    if (decryptedText.StartsWith("test"))
                    {
                        Console.WriteLine($"Decrypted plaintext: {decryptedText}");
                        Console.WriteLine($"Key used: {BitConverter.ToString(key).Replace("-", "")}");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Failed to decrypt.");
    }

    // Decrypt using DES with a given key
    static string DecryptDES(byte[] ciphertext, byte[] key)
    {
        using (DES des = DES.Create())
        {
            des.Key = key;
            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.Zeros;

            using (ICryptoTransform decryptor = des.CreateDecryptor())
            {
                byte[] decryptedBytes = decryptor.TransformFinalBlock(ciphertext, 0, ciphertext.Length);
                return Encoding.ASCII.GetString(decryptedBytes);
            }
        }
    }

    // Helper function to convert a hexadecimal string to a byte array
    static byte[] HexStringToByteArray(string hex)
    {
        int numberChars = hex.Length;
        byte[] bytes = new byte[numberChars / 2];
        for (int i = 0; i < numberChars; i += 2)
        {
            bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
        }
        return bytes;
    }
}
