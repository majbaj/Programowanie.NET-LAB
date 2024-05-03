using System;
using System.IO;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string sourceFilePath = @"C:\Users\Latitude7490\Desktop\SEM4\Programowanie .NET - L\L1\NET_Zad7\duzyplik.txt";
        string destinationFilePathFileStream = @"C:\Users\Latitude7490\Desktop\SEM4\Programowanie .NET - L\L1\NET_Zad7\kopiaFileStream.txt";
        string destinationFilePathFileCopy = @"C:\Users\Latitude7490\Desktop\SEM4\Programowanie .NET - L\L1\NET_Zad7\kopiaFileCopy.txt";
        string destinationFilePathBufferedStream = @"C:\Users\Latitude7490\Desktop\SEM4\Programowanie .NET - L\L1\NET_Zad7\kopiaBufferedStream.txt";

        // Generowanie pliku źródłowego
        int fileSizeMB = 300;
        GenerateLargeFile(sourceFilePath, fileSizeMB);
        Console.WriteLine("Plik o wielkości 300 MB został wygenerowany.");

        // Pomiar czasu kopiowania za pomocą FileStream
        Stopwatch stopwatch = Stopwatch.StartNew();
        CopyUsingFileStream(sourceFilePath, destinationFilePathFileStream);
        stopwatch.Stop();
        Console.WriteLine($"Czas kopiowania za pomocą FileStream: {stopwatch.ElapsedMilliseconds} ms");

        // Pomiar czasu kopiowania za pomocą File.Copy
        stopwatch.Restart();
        CopyUsingFileCopy(sourceFilePath, destinationFilePathFileCopy);
        stopwatch.Stop();
        Console.WriteLine($"Czas kopiowania za pomocą File.Copy: {stopwatch.ElapsedMilliseconds} ms");

        // Pomiar czasu kopiowania za pomocą BufferedStream
        stopwatch.Restart();
        CopyUsingBufferedStream(sourceFilePath, destinationFilePathBufferedStream);
        stopwatch.Stop();
        Console.WriteLine($"Czas kopiowania za pomocą BufferedStream: {stopwatch.ElapsedMilliseconds} ms");
    }

    static void GenerateLargeFile(string filePath, int sizeMB)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            long fileSize = sizeMB * 1024L * 1024L; // Rozmiar w bajtach
            byte[] buffer = new byte[1024 * 1024]; // Bufor 1 MB

            // Wypełnienie pliku danymi
            long bytesWritten = 0;
            while (bytesWritten < fileSize)
            {
                int bytesToWrite = (int)Math.Min(buffer.Length, fileSize - bytesWritten);
                fs.Write(buffer, 0, bytesToWrite);
                bytesWritten += bytesToWrite;
            }
        }
    }

    static void CopyUsingFileStream(string sourceFilePath, string destinationFilePathFileStream)
    {
        using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
        {
            using (FileStream destinationStream = new FileStream(destinationFilePathFileStream, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024 * 1024]; // Bufor 1 MB
                int bytesRead;
                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destinationStream.Write(buffer, 0, bytesRead);
                }
            }
        }
    }

    static void CopyUsingFileCopy(string sourceFilePath, string destinationFilePathFileCopy)
    {
        File.Copy(sourceFilePath, destinationFilePathFileCopy);
    }

    static void CopyUsingBufferedStream(string sourceFilePath, string destinationFilePathBufferedStream)
    {
        using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
        {
            using (FileStream destinationStream = new FileStream(destinationFilePathBufferedStream, FileMode.Create, FileAccess.Write))
            {
                using (BufferedStream bufferedStream = new BufferedStream(sourceStream))
                {
                    bufferedStream.CopyTo(destinationStream);
                }
            }
        }
    }

}