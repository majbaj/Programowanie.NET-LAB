using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string sourceFilePath = @"C:\Users\Latitude7490\Desktop\SEM4\Programowanie .NET - L\L1\NET_Zad6\Vamos a la playa.txt";
            string destinationFilePath = @"C:\Users\Latitude7490\Desktop\SEM4\Programowanie .NET - L\L1\NET_Zad6\kopia.txt";

            CopyFile(sourceFilePath, destinationFilePath);

            Console.WriteLine("Plik został skopiowany.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd: " + ex.Message);
        }
    }

    static void CopyFile(string sourceFilePath, string destinationFilePath)
    {
        using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
        {
            using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destinationStream.Write(buffer, 0, bytesRead);
                }
            }
        }
    }
}