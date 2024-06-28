using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.Json;
using System.IO;

namespace EncryptionApp
{
    public class Configuration
    {
        public byte[] EncryptionKey { get; set; }
        public byte[] InitializationVector { get; set; }

        public Configuration()
        {
            // Example key and IV generation
            using (Aes aes = Aes.Create())
            {
                aes.GenerateKey();
                aes.GenerateIV();
                EncryptionKey = aes.Key;
                InitializationVector = aes.IV;
            }
        }

        public void Save(string filePath)
        {
            var json = JsonSerializer.Serialize(this);
            File.WriteAllText(filePath, json);
        }

        public static Configuration Load(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Configuration>(json);
        }
    }
}
