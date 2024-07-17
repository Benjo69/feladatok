using System;
using System.IO;
using System.Windows.Forms;

namespace telefonkonyvwinforms
{
    public partial class listaForm : Form
    {
        public listaForm()
        {
            InitializeComponent();
            if (!File.Exists("kontaktok.dat"))
            {
                MessageBox.Show("Fájl megnyitási hiba a listázásnál", "Hiba");
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

                    lblNev.Text = $"Név: {p.Nev}";
                    lblCim.Text = $"Cím: {p.Cim}";
                    lblApa.Text = $"Apa neve: {p.ApaNeve}";
                    lblAnya.Text = $"Anya neve: {p.AnyaNeve}";
                    lblTelefon.Text = $"TelefonSzám: {p.Telefonszam}";
                    lblNem.Text = $"Neme: {p.Neme}";
                    lblEmail.Text = $"Email: {p.Email}";
                    lblSzemely.Text = $"Személyazonosító száma: {p.SzemelyAzon}";
                }
            }
        }

        private void btnKovetkezo_Click(object sender, EventArgs e)
        {
            if (!File.Exists("kontaktok.dat"))
            {
                MessageBox.Show("Fájl megnyitási hiba a listázásnál", "Hiba");
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

                    lblNev.Text = $"Név: {p.Nev}";
                    lblCim.Text = $"Cím: {p.Cim}";
                    lblApa.Text = $"Apa neve: {p.ApaNeve}";
                    lblAnya.Text = $"Anya neve: {p.AnyaNeve}";
                    lblTelefon.Text = $"TelefonSzám: {p.Telefonszam}";
                    lblNem.Text = $"Neme: {p.Neme}";
                    lblEmail.Text = $"Email: {p.Email}";
                    lblSzemely.Text = $"Személyazonosító száma: {p.SzemelyAzon}";

                    if (fs.Position == fs.Length)
                    {
                        MessageBox.Show("Ennyi kontakt van elmentve", "Vége");
                    }
                }
            }
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan Kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }
    }
}
