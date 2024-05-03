using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Zad1
{
    internal class Garaz
    {
        private string adres;
        private int pojemnosc;
        private int liczbaSamochodow;
        private Samochod[] samochody;


        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public int Pojemnosc
        {
            get { return pojemnosc; }
            set
            {
                pojemnosc = value;
                samochody = new Samochod[pojemnosc];
            }
        }


        public Garaz()
        {
            adres = "nieznany";
            pojemnosc = 0;
            liczbaSamochodow = 0;
        }

    public Garaz(string adres_, int pojemnosc_)
        {
            adres = adres_;
            pojemnosc = pojemnosc_;
            samochody = new Samochod[pojemnosc];
        }

        public void WprowadzSamochod(Samochod samochod)
        {
            if (liczbaSamochodow < pojemnosc)
            {
                samochody[liczbaSamochodow] = samochod;
                liczbaSamochodow++;
            }
            else
            {
                Console.WriteLine("Garaż jest pełny, nie można dodać więcej samochodów.");
            }
        }

        public Samochod WyprowadzSamochod()
        {
            if (liczbaSamochodow > 0)
            {
                Samochod samochod = samochody[liczbaSamochodow - 1];
                samochody[liczbaSamochodow - 1] = null;
                liczbaSamochodow--;
                return samochod;
            }
            else
            {
                Console.WriteLine("Garaż jest pusty, nie można wyprowadzić samochodu.");
                return null;
            }
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Adres garażu: " + adres);
            Console.WriteLine("Pojemność garażu: " + pojemnosc);
            Console.WriteLine("Liczba samochodów w garażu: " + liczbaSamochodow);
            Console.WriteLine("Informacje o samochodach w garażu:");
            for (int i = 0; i < liczbaSamochodow; i++)
            {
                Console.WriteLine("Samochód " + (i + 1) + ":");
                samochody[i].WypiszInfo();
                Console.WriteLine();
            }
        }


    }
}
