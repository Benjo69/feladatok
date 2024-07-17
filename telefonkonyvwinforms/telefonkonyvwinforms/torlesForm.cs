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

namespace telefonkonyvwinforms
{
    public partial class torlesForm : Form
    {
        public torlesForm()
        {
            InitializeComponent();
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            string Nev = txtSzemely.Text;

            if (!File.Exists("kontaktok.dat"))
            {
                MessageBox.Show("A KAPCSOLAT ADATAI MÉG NEM LETTEK HOZZÁADVA", "Hiba");
            }
            else
            {
                bool found = false;
                string tempFileNev = "temp.dat";

                using (FileStream fs = new FileStream("kontaktok.dat", FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(fs))
                using (FileStream tempFs = new FileStream(tempFileNev, FileMode.Create, FileAccess.Write))
                using (BinaryWriter writer = new BinaryWriter(tempFs))
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

                        if (!p.Nev.Equals(Nev, StringComparison.OrdinalIgnoreCase))
                        {
                            writer.Write(p.Nev);
                            writer.Write(p.Cim);
                            writer.Write(p.ApaNeve);
                            writer.Write(p.AnyaNeve);
                            writer.Write(p.Telefonszam);
                            writer.Write(p.Neme);
                            writer.Write(p.Email);
                            writer.Write(p.SzemelyAzon);
                        }
                        else
                        {
                            found = true;
                        }
                    }
                }

                if (found)
                {
                    File.Delete("kontaktok.dat");
                    File.Move(tempFileNev, "kontaktok.dat");
                    label2.Text = "A REKORD SIKERESEN TÖRÖLVE.";
                    label2.Visible = true;
                }
                else
                {
                    File.Delete(tempFileNev);
                    label2.Text = "NINCS KAPCSOLATREKORD A TÖRLÉSHEZ.";
                    label2.Visible = true;
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