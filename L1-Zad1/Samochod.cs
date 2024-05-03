using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Zad1
{
    internal class Samochod
    {
        private string marka;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        private double srednieSpalanie;

        private static int iloscSamochodow = 0;

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }

        public int PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }

        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }
        }

        public Samochod()
        {
            marka = "nieznana";
            model = "nieznany";
            iloscDrzwi = 0;
            pojemnoscSilnika = 0;
            srednieSpalanie = 0.0;
            iloscSamochodow++;
        }

        public Samochod(string marka_, string model_, int iloscDrzwi_, int pojemnoscSilnika_, double srednieSpalanie_)
        {
            marka = marka_;
            model = model_;
            iloscDrzwi = iloscDrzwi_;
            pojemnoscSilnika = pojemnoscSilnika_;
            srednieSpalanie = srednieSpalanie_;
            iloscSamochodow++;
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            double spalanie = (srednieSpalanie * dlugoscTrasy) / 100.0;
            return spalanie;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double spalanie = ObliczSpalanie(dlugoscTrasy);
            double kosztPrzejazdu = spalanie * cenaPaliwa;
            return kosztPrzejazdu;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Ilość drzwi: " + iloscDrzwi);
            Console.WriteLine("Pojemność silnika: " + pojemnoscSilnika + " cm3");
            Console.WriteLine("Średnie spalanie: " + srednieSpalanie + " l/100km");
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine("Liczba utworzonych samochodów: " + iloscSamochodow);
        }
    }
}

