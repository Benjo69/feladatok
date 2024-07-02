using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uszoverseny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AdatBeolvasas()
        {
            StreamReader sr = new StreamReader("uszok.txt");

            string adat = sr.ReadLine();
            while (adat != null)
            {
                Feldolgoz(adat);
                adat = sr.ReadLine();
            }
            sr.Close();
        }

        private void Feldolgoz(string adat)
        {
            string rajtSzam, nev, orszag;
            DateTime szulDatum;
            TimeSpan idoEredmeny;
            Versenyzo versenyzo;
            string[] tordelt = adat.Split(';');
            rajtSzam = tordelt[0];
            nev = tordelt[1];
            szulDatum = DateTime.Parse(tordelt[2]);
            orszag = tordelt[3];
            idoEredmeny = TimeSpan.Parse("0:" + tordelt[4]);
            versenyzo = new Versenyzo(rajtSzam, nev, szulDatum, orszag, idoEredmeny);
            lstVersenyzok.Items.Add(versenyzo);
        }

        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            lstVersenyzok.Items.Clear();
            AdatBeolvasas();
            btnAdatBe.Enabled = false;
            btnGyoztes.Enabled = true;
        }

        private void lstVersenyzok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Versenyzo versenyzo = lstVersenyzok.SelectedItem as Versenyzo;
            txtRajtszam.Text = versenyzo.Rajtszam;
            txtOrszag.Text = versenyzo.Orszag;
            txtIdoEredmeny.Text = new DateTime(versenyzo.IdoEredmeny.Ticks).ToString("mm:ss.ff");
            txtEletKor.Text = (DateTime.Now.Year - versenyzo.SzulDatum.Year) + "év";
        }

        private void btnGyoztes_Click(object sender, EventArgs e)
        {
            TimeSpan min = (lstVersenyzok.Items[0] as Versenyzo).IdoEredmeny;
            foreach (var item in lstVersenyzok.Items)
            {
                if ((item as Versenyzo).IdoEredmeny < min)
                {
                    min = (item as Versenyzo).IdoEredmeny;
                }
            }
            txtGyoztesIdo.Text = new DateTime(min.Ticks).ToString("mm:ss.ff");
            tchTxtGyoztes.Clear();
            foreach (var item in lstVersenyzok.Items)
            {
                if ((item as Versenyzo).IdoEredmeny == min)
                {
                    tchTxtGyoztes.AppendText(item + "\n");
                }
            }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan Kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }
    }

    internal class Versenyzo
    {
        public string Rajtszam { get; private set; }
        public string Nev { get; private set; }
        public DateTime SzulDatum { get; private set; }
        public string Orszag { get; private set; }
        public TimeSpan IdoEredmeny { get; private set; }

        public Versenyzo(string rajtszam, string nev, DateTime szulDatum, string orszag, TimeSpan idoEredmeny)
        {
            Rajtszam = rajtszam;
            Nev = nev;
            SzulDatum = szulDatum;
            Orszag = orszag;
            IdoEredmeny = idoEredmeny;
        }

        public override string ToString()
        {
            return Nev;
        }
    }
}