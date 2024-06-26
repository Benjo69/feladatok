using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Schema;

namespace ConsoleApp3
{
    class Versenyzo
    {
        private string nev;
        private string szak;
        private int rajtSzam;
        private int pontSzam;

        public Versenyzo(string nev, string szak, int rajtSzam)
        {
            this.nev = nev;
            this.szak = szak;
            this.rajtSzam = rajtSzam;
        }

        public void PontszamNoveles(int pont)
        {
            this.pontSzam += pont;
        }

        public override string ToString()
        {
            return $"|{rajtSzam, -10}|{nev,-20}|{szak,-20}|{pontSzam,5} pont|";
        }

        public string Nev { get { return nev; } }
        public string Szak { get { return szak; } }
        public int RajtSzam { get { return rajtSzam; } }
        public int PontSzam { get { return pontSzam; } }
    }

    class VezerloOsztaly
    {
        private List<Versenyzo> versenyzok = new List<Versenyzo>();

        private int zsuri = 5;
        private int maxPont = 10;

        public void Start()
        {
            AdatBevitel();
            Kiiratas("\nRésztvevők:\n");
            Verseny();
            Kiiratas("\nEredmények;\n");
            Eredmenyek();
            Keresesek();
            Kereses();
        }

        private void AdatBevitel()
        {
            int sorszam = 1;
            string nev, szak;

            StreamReader sr = new StreamReader("D:/versenyzok.txt");

            while (!sr.EndOfStream)
            {
                nev = sr.ReadLine();
                szak = sr.ReadLine();
                versenyzok.Add(new Versenyzo(nev, szak, sorszam));
                sorszam++;
            }

            sr.Close();
        }

        private void Kiiratas(string cim)
        {
            Console.WriteLine(cim);
            foreach (Versenyzo enekes in versenyzok)
            {
                Console.WriteLine("+----------+--------------------+--------------------+----------+");
                Console.WriteLine(enekes);
            }
            Console.WriteLine("+----------+--------------------+--------------------+----------+");
        }

        private void Verseny()
        {
            Random rand = new Random();
            int pont;
            foreach (Versenyzo versenyzo in versenyzok)
            {
                for (int i = 0; i < zsuri; i++)
                {
                    pont = rand.Next(maxPont);
                    versenyzo.PontszamNoveles(pont);
                }
            }
        }

        private void Eredmenyek()
        {
            Nyertes();
            Sorrend();
        }

        private void Nyertes()
        {
            int max = versenyzok[0].PontSzam;
            foreach (Versenyzo enekes in versenyzok)
            {
                if (enekes.PontSzam > max)
                {
                    max = enekes.PontSzam;
                }
            }

            Console.WriteLine("\nA legjobb(ak)\n");
            foreach (Versenyzo enekes in versenyzok)
            {
                if (enekes.PontSzam == max)
                {
                    Console.WriteLine("+----------+--------------------+--------------------+----------+");
                    Console.WriteLine(enekes);
                }
            }
            Console.WriteLine("+----------+--------------------+--------------------+----------+");
        }

        private void Sorrend()
        {
            Versenyzo temp;
            for (int i = 0; i < versenyzok.Count; i++)
            {
                for (int j = 0; j < versenyzok.Count; j++)
                {
                    if (versenyzok[i].PontSzam < versenyzok[j].PontSzam)
                    {
                        temp = versenyzok[i];
                        versenyzok[i] = versenyzok[j];
                        versenyzok[j] = temp;
                    }
                }
            }
            Kiiratas("\nEredménytábla\n");
        }

        private void Keresesek()
        {
            Console.WriteLine("\nAdott szakhoz tartozó énekesek keresése\n");
            Console.WriteLine("\nKeres valaki? (i/n) ");
            char valasz;
            while (!char.TryParse(Console.ReadLine(), out valasz))
            {
                Console.WriteLine("Egy karaktert írjon. ");
            }
            string szak;
            bool vanIlyen;
            while (valasz == 'i' || valasz == 'I')
            {
                Console.WriteLine("Szak: ");
                szak = Console.ReadLine();
                vanIlyen = false;

                foreach (Versenyzo enekes in versenyzok)
                {
                    if (enekes.Szak == szak.ToLower())
                    {
                        Console.WriteLine(enekes);
                        vanIlyen = true;
                    }
                }

                if (!vanIlyen)
                {
                    Console.WriteLine("Erröl a szakrol senki nem indult.");
                }

                Console.WriteLine("\nKeres még valakit? (i/n) ");
                valasz = char.Parse(Console.ReadLine());
            }
        }

        private void Kereses()
        {
            Console.WriteLine("\nKeresés versenyzők között\n");
            Console.WriteLine("Keresési típus (1: Név, 2: Szak, 3: Sorszám): ");
            string keresesiTipus = Console.ReadLine();

            bool isValidType = keresesiTipus == "1" || keresesiTipus == "2" || keresesiTipus == "3";

            while (!isValidType)
            {
                Console.WriteLine("Érvénytelen választás, kérjük, válasszon újra (1: Név, 2: Szak, 3: Sorszám): ");
                keresesiTipus = Console.ReadLine();
                isValidType = keresesiTipus == "1" || keresesiTipus == "2" || keresesiTipus == "3";
            }

            Console.WriteLine("\nKeresési érték: ");
            string keresesiErtek = Console.ReadLine();

            bool vanIlyen = false;
            foreach (Versenyzo enekes in versenyzok)
            {
                if ((keresesiTipus == "1" && enekes.Nev.Equals(keresesiErtek, StringComparison.OrdinalIgnoreCase)) ||
                    (keresesiTipus == "2" && enekes.Szak.Equals(keresesiErtek, StringComparison.OrdinalIgnoreCase)) ||
                    (keresesiTipus == "3" && enekes.RajtSzam.ToString() == keresesiErtek))
                {
                    Console.WriteLine(enekes);
                    vanIlyen = true;
                }
            }

            if (!vanIlyen)
            {
                Console.WriteLine("Nincs ilyen versenyző.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            new VezerloOsztaly().Start();

            Console.ReadLine();
        }
    }
}
