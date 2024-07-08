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

namespace úszóverseny2
{
    public partial class Form1 : Form
    {
        private List<Versenyzo> versenyzok = new List<Versenyzo>();
        private VersenyForm versenyForm = new VersenyForm();
        private EredmenyForm eredmenyForm = new EredmenyForm();

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "versenyzok.txt";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.FileName = "mentettadatok.txt";
        }

        private void megnyitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    sr = new StreamReader(fajlNev);
                    AdatBevitel(sr);
                    mentesToolStripMenuItem1.Enabled = true;
                    versenyToolStripMenuItem.Enabled = true;
                    versenyForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hibaüznet a fejlesztő számára");
                }
                finally
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                }
            }
        }

        private void AdatBevitel(StreamReader sr)
        {
            string sor = sr.ReadLine();
            string[] adatok;
            while (sor != null)
            {
                adatok = sor.Split(';');
                versenyzok.Add(new Versenyzo(adatok[0], adatok[1], adatok[2]));
                sor = sr.ReadLine();
            }
        }

        private void versenyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            versenyForm.Fogad(versenyzok);
            this.Hide();
            versenyForm.ShowDialog();
            this.Show();

            eredmenyToolStripMenuItem.Enabled = true;
            versenyToolStripMenuItem.Enabled = false;
            mentesToolStripMenuItem1.Enabled = true;
            int tav = versenyForm.Tav;
            string uszasNem = versenyForm.UszasNem;
            eredmenyForm.EredmenyHirdetes(uszasNem, tav, versenyzok);
        }

        private void eredmenyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            eredmenyForm.ShowDialog();
            this.Show();
        }

        private void mentesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = null;
                try
                {
                    string fajlNev = saveFileDialog1.FileName;
                    sw = new StreamWriter(fajlNev);
                    FajlbaIr(sw);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba a fájl írásakor", "hiba");
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Close();
                    }
                }
            }
        }
        private void FajlbaIr(StreamWriter sw)
        {
            foreach (var versenyzo in versenyzok)
            {
                sw.WriteLine(versenyzo.Rajtszam + ";" + versenyzo.Nev + ";" + versenyzo.Orszag + ";" + versenyzo.IdoEredmeny);
            }
        }

        private void nevjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string keszito = "Benjo";
            NevjegyForm about = new NevjegyForm(keszito);
            about.ShowDialog();
        }
    }

    public class Versenyzo
    {
        public string Nev { get; private set; }
        public string Orszag { get; private set; }
        public string Zaszlo { get; private set; }
        public TimeSpan IdoEredmeny { get; private set; }
        public string Rajtszam { get; private set; }

        public void Versenyez(TimeSpan idoEredmeny)
        {
            this.IdoEredmeny = idoEredmeny;
        }

        public override string ToString()
        {
            return this.Nev;
        }

        private static int sorSzam;

        public Versenyzo(string nev, string orszag, string zaszlo)
        {
            this.Nev = nev;
            this.Orszag = orszag;
            this.Zaszlo = zaszlo;
            sorSzam++;
            this.Rajtszam = (sorSzam < 10) ? ("0" + sorSzam) : sorSzam.ToString();
        }
    }
}