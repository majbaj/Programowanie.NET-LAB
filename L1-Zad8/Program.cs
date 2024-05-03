using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace TaskManager
{
    class Zadanie
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public DateTime DataZakonczenia { get; set; }
        public bool CzyWykonane { get; set; }

        public Zadanie(int id, string nazwa, string opis, DateTime dataZakonczenia)
        {
            Id = id;
            Nazwa = nazwa;
            Opis = opis;
            DataZakonczenia = dataZakonczenia;
            CzyWykonane = false;
        }
    }

    class ManagerZadan
    {
        public List<Zadanie> listaZadan;

        public ManagerZadan()
        {
            listaZadan = new List<Zadanie>();
        }

        public void DodajZadanie(Zadanie zadanie)
        {
            listaZadan.Add(zadanie);
        }

        public void UsunZadanie(int id)
        {
            listaZadan.RemoveAll(z => z.Id == id);
        }

        public void WyswietlZadania()
        {
            foreach (var zadanie in listaZadan)
            {
                Console.WriteLine($"Id: {zadanie.Id}, Nazwa: {zadanie.Nazwa}, Opis: {zadanie.Opis}, Data zakończenia: {zadanie.DataZakonczenia}, Wykonane: {zadanie.CzyWykonane}");
            }
        }

        public void ZapiszDoPliku(string nazwaPliku)
        {
            string json = JsonSerializer.Serialize(listaZadan);
            File.WriteAllText(nazwaPliku, json);
        }

        public void WczytajZPliku(string nazwaPliku)
        {
            if (File.Exists(nazwaPliku))
            {
                string json = File.ReadAllText(nazwaPliku);
                listaZadan = JsonSerializer.Deserialize<List<Zadanie>>(json);
            }
            else
            {
                Console.WriteLine("Plik nie istnieje.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ManagerZadan manager = new ManagerZadan();

            while (true)
            {
                Console.WriteLine("1. Dodaj zadanie");
                Console.WriteLine("2. Usuń zadanie");
                Console.WriteLine("3. Wyświetl zadania");
                Console.WriteLine("4. Zapisz do pliku");
                Console.WriteLine("5. Wczytaj z pliku");
                Console.WriteLine("6. Wyjdź");

                Console.Write("Wybierz opcję: ");
                int opcja;
                if (!int.TryParse(Console.ReadLine(), out opcja))
                {
                    Console.WriteLine("Niepoprawna opcja.");
                    continue;
                }

                switch (opcja)
                {
                    case 1:
                        Console.Write("Podaj nazwę zadania: ");
                        string nazwa = Console.ReadLine();
                        Console.Write("Podaj opis zadania: ");
                        string opis = Console.ReadLine();
                        Console.Write("Podaj datę zakończenia zadania (rrrr-mm-dd): ");
                        if (!DateTime.TryParse(Console.ReadLine(), out DateTime dataZakonczenia))
                        {
                            Console.WriteLine("Niepoprawny format daty.");
                            continue;
                        }
                        Zadanie noweZadanie = new Zadanie(manager.listaZadan.Count + 1, nazwa, opis, dataZakonczenia);
                        manager.DodajZadanie(noweZadanie);
                        break;
                    case 2:
                        Console.Write("Podaj id zadania do usunięcia: ");
                        if (!int.TryParse(Console.ReadLine(), out int idDoUsuniecia))
                        {
                            Console.WriteLine("Niepoprawne id zadania.");
                            continue;
                        }
                        manager.UsunZadanie(idDoUsuniecia);
                        break;
                    case 3:
                        manager.WyswietlZadania();
                        break;
                    case 4:
                        Console.Write("Podaj nazwę pliku do zapisu: ");
                        string nazwaPlikuZapis = Console.ReadLine();
                        manager.ZapiszDoPliku(nazwaPlikuZapis);
                        break;
                    case 5:
                        Console.Write("Podaj nazwę pliku do wczytania: ");
                        string nazwaPlikuWczytaj = Console.ReadLine();
                        manager.WczytajZPliku(nazwaPlikuWczytaj);
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Niepoprawna opcja.");
                        break;
                }
            }
        }
    }
}