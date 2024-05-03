using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wybierz opcję:");
        Console.WriteLine("1. Zapisz dane do pliku");
        Console.WriteLine("2. Odczytaj dane z pliku");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                SaveDataToFile();
                break;
            case "2":
                ReadDataFromFile();
                break;
            default:
                Console.WriteLine("Nieprawidłowy wybór.");
                break;
        }
    }

    static void SaveDataToFile()
    {
        Console.WriteLine("Podaj dane do zapisu:");

        Console.Write("Imię: ");
        string name = Console.ReadLine();

        Console.Write("Wiek: ");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Podaj poprawny wiek:");
        }

        Console.Write("Adres: ");
        string address = Console.ReadLine();

        try
        {
            using (FileStream fs = new FileStream("dane.bin", FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, new UserData(name, age, address));
                Console.WriteLine("Dane zostały zapisane do pliku.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd podczas zapisu danych: " + ex.Message);
        }
    }

    static void ReadDataFromFile()
    {
        try
        {
            using (FileStream fs = new FileStream("dane.bin", FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                UserData userData = (UserData)formatter.Deserialize(fs);

                Console.WriteLine("Wczytane dane:");
                Console.WriteLine("Imię: " + userData.Name);
                Console.WriteLine("Wiek: " + userData.Age);
                Console.WriteLine("Adres: " + userData.Address);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Plik z danymi nie istnieje.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd podczas odczytu danych: " + ex.Message);
        }
    }
}

[Serializable]
class UserData
{
    public string Name { get; }
    public int Age { get; }
    public string Address { get; }

    public UserData(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }
}