using EncryptionApp;
using System.IO;
using System.Security.Cryptography;

internal class EncryptionService
{
    public string EncryptFile(string filePath, Configuration config)
    {
        // Read file
        var fileContent = File.ReadAllBytes(filePath);
        byte[] encryptedContent;
        using (Aes aes = Aes.Create())
        {
            aes.Key = config.EncryptionKey;
            aes.IV = config.InitializationVector;

            using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
            {
                encryptedContent = PerformCryptography(fileContent, encryptor);
            }
        }

        // Create encrypted file path
        var encryptedFilePath = GetEncryptedFilePath(filePath);
        File.WriteAllBytes(encryptedFilePath, encryptedContent);
        return encryptedFilePath;
    }

    public string DecryptFile(string filePath, Configuration config)
    {
        // Read encrypted file
        var encryptedContent = File.ReadAllBytes(filePath);
        byte[] decryptedContent;
        using (Aes aes = Aes.Create())
        {
            aes.Key = config.EncryptionKey;
            aes.IV = config.InitializationVector;

            using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
            {
                decryptedContent = PerformCryptography(encryptedContent, decryptor);
            }
        }

        // Create decrypted file path
        var decryptedFilePath = GetDecryptedFilePath(filePath);
        File.WriteAllBytes(decryptedFilePath, decryptedContent);
        return decryptedFilePath;
    }

    private byte[] PerformCryptography(byte[] data, ICryptoTransform cryptoTransform)
    {
        using (var memoryStream = new MemoryStream())
        {
            using (var cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
            {
                cryptoStream.Write(data, 0, data.Length);
                cryptoStream.FlushFinalBlock();
            }
            return memoryStream.ToArray();
        }
    }

    private string GetEncryptedFilePath(string filePath)
    {
        var directory = Path.GetDirectoryName(filePath);
        var fileName = Path.GetFileNameWithoutExtension(filePath);
        var extension = Path.GetExtension(filePath);
        return Path.Combine(directory, $"{fileName}.encrypted{extension}");
    }

    private string GetDecryptedFilePath(string filePath)
    {
        var directory = Path.GetDirectoryName(filePath);
        var fileName = Path.GetFileNameWithoutExtension(filePath);
        var extension = Path.GetExtension(filePath);

        // Remove ".encrypted" from the file name
        if (fileName.EndsWith(".encrypted"))
        {
            fileName = fileName.Substring(0, fileName.Length - ".encrypted".Length);
        }

        return Path.Combine(directory, $"{fileName}{extension}");
    }
}
