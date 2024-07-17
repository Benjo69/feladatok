using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telefonkonyvwinforms
{
    public partial class Form1 : Form
    {
        Person p = new Person();
        ujKontakt ujkontakt = new ujKontakt();
        Keresés keresés = new Keresés();
        listaForm listaForm = new listaForm();
        modositasForm modositasForm = new modositasForm();
        torlesForm torlesForm = new torlesForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            ujkontakt.Show();
        }

        private void btnKeres_Click(object sender, EventArgs e)
        {
            keresés.Show();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            modositasForm.Show();
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan Kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            listaForm.Show();
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            torlesForm.Show();
        }
    }
    public class Person
    {
        public string Nev { get; set; }
        public string Cim { get; set; }
        public string ApaNeve { get; set; }
        public string AnyaNeve { get; set; }
        public long Telefonszam { get; set; }
        public string Neme { get; set; }
        public string Email { get; set; }
        public string SzemelyAzon { get; set; }
    }
}
