using System;
using System.IO;
using System.Windows.Forms;

namespace telefonkonyvwinforms
{
    public partial class modositasForm : Form
    {
        public modositasForm()
        {
            InitializeComponent();
        }

        private async void btnKeres_Click(object sender, EventArgs e)
        {
            string Nev = txtSzemely.Text;
            bool found = false;

            if (!File.Exists("kontaktok.dat"))
            {
                MessageBox.Show("A KAPCSOLAT ADATAI MÉG NEM LETTEK HOZZÁADVA");
                this.Close();
            }
            using (FileStream fs = new FileStream("kontaktok.dat", FileMode.Open, FileAccess.ReadWrite))
            using (BinaryReader reader = new BinaryReader(fs))
            using (BinaryWriter writer = new BinaryWriter(fs))
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
                        btnKeres.Visible = false;
                        lblNev.Visible = true;
                        txtNev.Visible = true;

                        lblCim.Visible = true;
                        txtCim.Visible = true;

                        lblApa.Visible = true;
                        txtApaNeve.Visible = true;

                        lblAnya.Visible = true;
                        txtAnyaNeve.Visible = true;

                        lblTelefon.Visible = true;
                        txtTelefon.Visible = true;

                        lblNem.Visible = true;
                        txtNem.Visible = true;

                        lblEmail.Visible = true;
                        txtEmail.Visible = true;

                        lblSzemely.Visible = true;
                        txtSzemelySzam.Visible = true;
                        btnModosit.Visible = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Az adatot nem találtuk");
            }
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            string Nev = txtSzemely.Text;
            bool found = false;

            if (!File.Exists("kontaktok.dat"))
            {
                MessageBox.Show("A KAPCSOLAT ADATAI MÉG NEM LETTEK HOZZÁADVA");
                this.Close();
            }
            using (FileStream fs = new FileStream("kontaktok.dat", FileMode.Open, FileAccess.ReadWrite))
            using (BinaryReader reader = new BinaryReader(fs))
            using (BinaryWriter writer = new BinaryWriter(fs))
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
                        p.Nev = txtNev.Text;
                        p.Cim = txtCim.Text;
                        p.ApaNeve = txtApaNeve.Text;
                        p.AnyaNeve = txtAnyaNeve.Text;
                        p.Telefonszam = long.Parse(txtTelefon.Text);
                        p.Neme = txtNem.Text;
                        p.Email = txtEmail.Text;
                        p.SzemelyAzon = txtSzemelySzam.Text;
                    }
                    fs.Seek(-(sizeof(long) + sizeof(char) + (p.Nev.Length + p.Cim.Length + p.ApaNeve.Length + p.AnyaNeve.Length + p.Neme.Length + p.Email.Length + p.SzemelyAzon.Length)), SeekOrigin.Current);

                    // Write the data to the file
                    writer.Write(p.Telefonszam);
                    writer.Write(p.Neme);
                    writer.Write(p.Email);
                    writer.Write(p.SzemelyAzon);

                    found = true;
                }
            }
            if (found)
            {
                MessageBox.Show("Az adatok módosítva lettek");
                this.Close();
            }
            else
            {
                MessageBox.Show("Az adatot nem találtuk");
                this.Close();
            }
        }
    }
}
