using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"C:\Users\Latitude7490\Desktop\SEM4\Programowanie .NET - L\L1\NET_Zad4\Vamos a la playa.txt";

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                Console.WriteLine("Zawartość pliku (odwrócona kolejność znaków):");
                Console.WriteLine("---------------------------------------------");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    char[] charArray = line.ToCharArray();
                    Array.Reverse(charArray);
                    Console.WriteLine(new string(charArray));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd: " + ex.Message);
        }
    }
}