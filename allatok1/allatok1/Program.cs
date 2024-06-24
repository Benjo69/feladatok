using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace allatok1
{

    class Allat
    {
        private string nev;
        private int szuletesiEv;
        private int szepsegPont, viselkedesPont;
        private int pontSzam;
        private static int aktualisEv;
        private static int korHatar;

        public Allat(string nev, int szuletesiEv)
        {
            this.nev = nev;
            this.szuletesiEv = szuletesiEv;
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
            return $"{this.nev} pontszáma: {this.pontSzam} pont";
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
            Allat allat;

            Allat.AktualisEv = 2015;
            Allat.KorHatar = 10;

            allat = new Allat("Buksi", 2016);
            allat.Pontozas(6, 5);
            
            Console.WriteLine(allat);
            
            Console.ReadKey();
        }
    }
}
