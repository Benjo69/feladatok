using System;
using System.IO;
using System.Windows.Forms;

namespace telefonkonyvwinforms
{
    public partial class Keresés : Form
    {
        public Keresés()
        {
            InitializeComponent();
        }

        private void btnKereses_Click(object sender, EventArgs e)
        {
            string Nev = txtSzemely.Text;

            bool found = false;

            if (!File.Exists("kontaktok.dat"))
            {
                MessageBox.Show("Hiba a megnyitáskor.", "Hiba");
                this.Close();
            }

            using (FileStream fs = new FileStream("kontaktok.dat", FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                while (fs.Position < fs.Length)
                {
                    Person p = new Person
                    {
                        Nev = reader.ReadString(),
                        Cim = reader.ReadString(),
                        ApaNeve = reader.ReadString(),
                        AnyaNeve = reader.ReadString(),
                        Telefonszam = reader.ReadInt64(),
                        Neme = reader.ReadString(),
                        Email = reader.ReadString(),
                        SzemelyAzon = reader.ReadString()
                    };

                    if (p.Nev.Equals(Nev, StringComparison.OrdinalIgnoreCase))
                    {
                        label2.Text = $" Részletes információ róla {p.Nev}";
                        lblNev.Text = $"Név: {p.Nev}";
                        lblCim.Text = $"Cím: {p.Cim}";
                        lblApa.Text = $"Apa neve: {p.ApaNeve}";
                        lblAnya.Text = $"Anya neve: {p.AnyaNeve}";
                        lblTelefon.Text = $"TelefonSzám: {p.Telefonszam}";
                        lblNem.Text = $"Neme: {p.Neme}";
                        lblEmail.Text = $"Email: {p.Email}";
                        lblSzemely.Text = $"Személyazonosító száma: {p.SzemelyAzon}";
                        label2.Visible = true;
                        lblTelefon.Visible = true;
                        lblEmail.Visible = true;
                        lblSzemely.Visible = true;
                        lblAnya.Visible = true;
                        lblApa.Visible = true;
                        lblNem.Visible = true;
                        lblNev.Visible = true;
                        lblCim.Visible = true;
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("A fájl nem található.", "Hiba");
            }
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan Kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }
    }
}