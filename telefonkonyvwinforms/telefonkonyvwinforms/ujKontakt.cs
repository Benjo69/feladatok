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
    public partial class ujKontakt : Form
    {
        public Person p = new Person();
        
        public ujKontakt()
        {
            InitializeComponent();
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            if (txtNev.Text != "" && txtCim.Text != "" && txtApaNeve.Text != "" && txtAnyaNeve.Text != "" && txtTelefon.Text != "" && txtNem.Text != "" && txtEmail.Text != "" && txtSzemelySzam.Text != "")
            {
                p.Nev = txtNev.Text;
                p.Cim = txtCim.Text;
                p.ApaNeve = txtApaNeve.Text;
                p.AnyaNeve = txtAnyaNeve.Text;
                p.Telefonszam = Int32.Parse(txtTelefon.Text);
                p.Neme = txtNem.Text;
                p.Email = txtEmail.Text;
                p.SzemelyAzon = txtSzemelySzam.Text;

                using (FileStream fs = new FileStream("kontaktok.dat", FileMode.Append, FileAccess.Write))
                using (BinaryWriter writer = new BinaryWriter(fs))
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
                MessageBox.Show("A rekord mentve.", "Sikeres mentés");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mindegyik mezőt töltse ki!", "Hiba");
            }
        }
    }
}
