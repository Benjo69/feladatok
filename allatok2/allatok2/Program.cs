using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace allatok2
{
    class Allat
    {
        private string nev;
        private int szuletesiEv;
        private int szepsegPont, viselkedesPont;
        private int pontSzam;
        private int oltasSzam;
        private int rajtszam;
        private static int aktualisEv;
        private static int korHatar;

        public Allat(string nev, int szuletesiEv, int oltasSzam)
        {
            this.nev = nev;
            this.szuletesiEv = szuletesiEv;
            this.oltasSzam = oltasSzam;
        }

        public int Kor()
        {
            return aktualisEv - szuletesiEv;
        }

        public void Pontozas(int szepsegPont, int viselkedesPont)
        {
            this.szepsegPont = szepsegPont;
            this.viselkedesPont = viselkedesPont;
            if (Kor() <= korHatar)
            {
                pontSzam = viselkedesPont * Kor() + szepsegPont * (korHatar - Kor());
            }
            else
            {
                pontSzam = 0;
            }
        }

        public override string ToString()
        {
            return $"{this.nev} pontszáma: {this.pontSzam} pont, rajtszáma: {rajtszam}";
        }

        public string Nev
        {
            get { return nev; }
        }

        public int SzuletesiEv
        {
            get { return szuletesiEv; }
        }
        public int SzepsegPont
        {
            get { return szepsegPont; }
        }
        public int ViselkedesPont
        {
            get { return viselkedesPont; }
        }
        public int PontSzam
        {
            get { return pontSzam; }
        }

        public int RajtSzam
        {
            get { return rajtszam; }
            set { rajtszam = value; }
        }

        public static int AktualisEv
        {
            get { return aktualisEv; }
            set { aktualisEv = value; }
        }

        public static int KorHatar
        {
            get { return korHatar; }
            set { korHatar = value; }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Allat.AktualisEv = 2015;
            Allat.KorHatar = 10;

            AllatVerseny();

            Console.ReadKey();
        }

        public static void AllatVerseny()
        {
            Allat allat;

            string nev;
            int szuletesEv;
            int szepsege, viselkedese;
            int oltasSzama;
            int veletlenPontHatar = 10;
            int versenyzoSzama = 0;

            Random rand = new Random();

            int osszesVersenyzo = 0;
            int osszesPont = 0;
            int legtobbPont = 0;

            char tovabb = 'i';
            while (tovabb == 'i')
            {
                Console.WriteLine("Az állat neve: ");
                nev = Console.ReadLine();

                Console.WriteLine($"{nev} oltási igazolás száma: ");
                oltasSzama = int.Parse(Console.ReadLine());

                Console.WriteLine($"{nev}születési éve: ");
                while (!int.TryParse(Console.ReadLine(), out szuletesEv) || szuletesEv <= 0 || szuletesEv > Allat.AktualisEv) 
                {
                    Console.WriteLine("Hibás adat, kérem újra.");
                }

                szepsege = rand.Next(veletlenPontHatar + 1);
                viselkedese = rand.Next(veletlenPontHatar + 1);

                allat = new Allat(nev, szuletesEv, oltasSzama);

                allat.RajtSzam = versenyzoSzama + 1;
                versenyzoSzama++;

                allat.Pontozas(szepsege, viselkedese);

                Console.WriteLine(allat);

                osszesVersenyzo++;
                osszesPont += allat.PontSzam;
                if (legtobbPont < allat.PontSzam)
                {
                    legtobbPont = allat.PontSzam;
                }

                Console.WriteLine("Van még állat?(i/n)");

                tovabb = char.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Összesen {osszesVersenyzo} versenyző volt, összpontszámuk: {osszesPont} pont, legtöbb pontszám: {legtobbPont}, átlaguk: {1.0 * osszesPont / osszesVersenyzo}");
        }
    }
}
