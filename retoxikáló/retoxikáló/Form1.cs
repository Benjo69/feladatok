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

namespace retoxikáló
{
    

    public partial class Form1 : Form
    {
        private List<Ital> italok = new List<Ital>();
        private List<Image> kepek = new List<Image>();
        private int kepekSzama = 10;
        private ItalLapForm italForm = new ItalLapForm();
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "retoxikalo.txt";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.FileName = "konyveles.txt";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                KepBetoltes();
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba a képek létrehozásakor", "Hiba");
            }
        }

        private void KepBetoltes()
        {
            Image kep;
            for (int i = 0; i < kepekSzama; i++)
            {
                kep = Image.FromFile("kep" + i+1 + ".jfif");
                kepek.Add(kep);
            }
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    sr = new StreamReader(fajlNev);
                    AdatBevitel(sr);
                    itallapToolStripMenuItem.Enabled = true;
                    mentésToolStripMenuItem.Enabled = true;
                    italForm.ArlapotIr(italok);
                    italForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hibaüznet a fejlesztő számára");
                }
                finally
                {
                    if ( sr != null)
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
                italok.Add(new Ital(adatok[0], int.Parse(adatok[1])));
                sor = sr.ReadLine();
            }
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
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
            foreach (Ital item in italok)
            {
                sw.WriteLine(item.Konyvelesbe());
            }
        }

        private void galeriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GaleriaForm galeriaForm = new GaleriaForm();
            galeriaForm.Atad(kepek);
            galeriaForm.Show();
        }

        private void nevjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Készült: prog2 gyakorlaton.", "információ");
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan Kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }
    }
    class Ital
    {
        public string ItalNev { get; private set; }
        public int EgysegAr { get; set; }
        public int Mennyiseg { get; private set; }
        public int OsszMennyiseg { get; private set; }
        public string Bevetel { get; private set; }

        public Ital(string ItalNev, int EgysegAr)
        {
            this.ItalNev = ItalNev;
            this.EgysegAr = EgysegAr;
        }

        public void Rendel(int db)
        {
            Mennyiseg += db;
        }

        public int Fizetendo()
        {
            return Mennyiseg * EgysegAr;
        }

        public void Fizet()
        {
            OsszMennyiseg += Mennyiseg;
            Bevetel += Mennyiseg * EgysegAr;
            Mennyiseg = 0;
        }
        public string Arlistaba()
        {
            return ItalNev + "(" + EgysegAr + " Ft)";
        }
        public string Konyvelesbe()
        {
            return ItalNev + ";" + OsszMennyiseg + ";" + Bevetel;
        }
        public override string ToString()
        {
            return Mennyiseg.ToString().PadLeft(4) + " " + ItalNev.PadRight(35) + " " + Fizetendo().ToString().PadLeft(10) + " Ft";
        }
    }
}
