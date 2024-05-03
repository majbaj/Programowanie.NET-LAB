using System;
using System.IO;
using System.Text;
class Program
{
    static void Main()
    {
        string path = @"C:\Users\Latitude7490\Desktop\SEM4\Programowanie .NET - L\L1\NET_Zad3\Vamos a la playa.txt";
        try

        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    // Wyświetlenie zawartości w konsoli
                    Console.WriteLine("Zawartość pliku:");
                    Console.WriteLine("----------------");
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
        }
catch (Exception ex)
        {
            // Obsługa wyjątków
            Console.WriteLine("Wystąpił błąd: " + ex.Message);
        }
    }
}