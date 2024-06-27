using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatverseny
{
    internal class Allat
    {
        public string nev { get; private set; }
        public int szuletesiEv { get; private set; }
        public int rajtSzam { get; private set; }
        public int szepsegPont { get; private set; }
        public int viselkedesPont { get; private set; }
        public static int aktualisEv { get; set; }
        public static int korHatar { get; set; }

        public Allat(string nev, int szuletesiEv, int rajtSzam)
        {
            this.nev = nev;
            this.szuletesiEv = szuletesiEv;
            this.rajtSzam = rajtSzam;
        }

        public int Kor()
        {
            return aktualisEv - szuletesiEv;
        }

        public virtual int PontSzam()
        {
            if (Kor() < korHatar)
            {
                return viselkedesPont * Kor() + szepsegPont * (korHatar - Kor());
            }
            return 0;
        }

        public void Pontozas(int szepsegPont, int viselkedesPont)
        {
            this.szepsegPont = szepsegPont;
            this.viselkedesPont = viselkedesPont;
        }

        public override string ToString()
        {
            return $"{rajtSzam}. {nev} nevű {this.GetType().Name.ToLower()} pontszáma: {PontSzam()} pont";
        }
    }

    internal class Kutya : Allat
    {
        public int gazadaViszonyPont { get; private set; }
        public bool kapottViszonyPont { get; private set; }

        public Kutya(string nev, int szuletesiEv, int rajtSzam) : base(nev, szuletesiEv, rajtSzam)
        {
        }

        public void ViszonyPontozas(int gazdaViszonyPont)
        {
            this.gazadaViszonyPont = gazdaViszonyPont;
            kapottViszonyPont = true;
        }

        public override int PontSzam()
        {
            int pont = 0;
            if (kapottViszonyPont)
            {
                pont = base.PontSzam() + gazadaViszonyPont;
            }
            return pont;
        }
    }

    internal class Macska : Allat
    {
        public bool vanMacskaSzallitoDoboz { get; set; }

        public Macska(string nev, int szuletesiEv, int rajtSzam, bool vanMacskaSzallitoDoboz) : base(nev, szuletesiEv, rajtSzam)
        {
            this.vanMacskaSzallitoDoboz = vanMacskaSzallitoDoboz;
        }

        public override int PontSzam()
        {
            if (vanMacskaSzallitoDoboz)
            {
                return base.PontSzam();
            }
            return 0;
        }
    }

    internal class Vezerles
    {
        private List<Allat> allatok = new List<Allat>();

        public void Start()
        {
            Allat.aktualisEv = 2015;
            Allat.korHatar = 10;

            Proba();

            Regisztracio();
            Kiiratas("A regisztrált versenyzők");
            Verseny();
            Kiiratas("A verseny eredménye");
        }

        private void Proba()
        {
            Allat allat1, allat2;
            string nev1 = "Pamacs", nev2 = "Bolhazsák";
            int szulEv1 = 2010, szulEv2 = 2011;
            bool vanDoboz = true;
            int rajtSzam = 1;

            int szepsegPont = 5, viselkedesPont = 4, viszonypont = 6;

            allat1 = new Kutya(nev1, szulEv1, rajtSzam);
            rajtSzam++;

            allat2 = new Macska(nev2, szulEv2, rajtSzam, vanDoboz);

            Console.WriteLine("A regisztrált állatok: ");
            Console.WriteLine(allat1);
            Console.WriteLine(allat2);

            allat2.Pontozas(szepsegPont, viselkedesPont);
            if (allat1 is Kutya)
            {
                (allat1 as Kutya).ViszonyPontozas(viszonypont);
            }

            allat1.Pontozas(szepsegPont, viselkedesPont);

            Console.WriteLine("\nA verseny eredménye: ");
            Console.WriteLine(allat1);
            Console.WriteLine(allat2);
        }

        private void Regisztracio()
        {
            StreamReader olvasoCsatorna = new StreamReader("d:/versenyzokk.txt");
            string fajta, nev;
            int rajtSzam = 1, szulEv;
            bool vanDoboz;

            while (!olvasoCsatorna.EndOfStream)
            {
                fajta = olvasoCsatorna.ReadLine();
                nev = olvasoCsatorna.ReadLine();
                szulEv = int.Parse(olvasoCsatorna.ReadLine());
                if (fajta == "kutya")
                {
                    allatok.Add(new Kutya(nev, szulEv, rajtSzam));
                }
                else
                {
                    vanDoboz = bool.Parse(olvasoCsatorna.ReadLine());
                    allatok.Add(new Macska(nev, szulEv, rajtSzam, vanDoboz));
                }
                rajtSzam++;
            }

            olvasoCsatorna.Close();
        }

        private void Verseny()
        {
            Random rand = new Random();
            int hatar = 11;
            foreach (Allat item in allatok)
            {
                if (item is Kutya)
                {
                    (item as Kutya).ViszonyPontozas(rand.Next(hatar));
                }
                item.Pontozas(rand.Next(hatar), rand.Next(hatar));
            }
        }

        private void Kiiratas(string cim)
        {
            Console.WriteLine(cim);
            foreach (Allat enekes in allatok)
            {
                Console.WriteLine(enekes);
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Vezerles vezerles = new Vezerles();
            vezerles.Start();

            Console.ReadKey();
        }
    }
}