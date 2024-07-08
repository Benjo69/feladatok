using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace úszóverseny2
{
    public partial class EredmenyForm : Form
    {
        private List<Versenyzo> versenyzok;
        public EredmenyForm()
        {
            InitializeComponent();
        }

        public void EredmenyHirdetes(string uszassNem, int tav, List<Versenyzo> versenyzok)
        {
            lblSzoveg.Text = tav + " méteres " + uszassNem + " eredménye: ";
            this.versenyzok = versenyzok;
            foreach (Versenyzo versenyzo in versenyzok)
            {
                listBox1.Items.Add(versenyzo);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Versenyzo versenyzo = (Versenyzo)listBox1.SelectedItem;
                txtRajt.Text = versenyzo.Rajtszam;
                txtOrszag.Text = versenyzo.Orszag;
                txtIdo.Text = new DateTime(versenyzo.IdoEredmeny.Ticks).ToString("mm:ss");
            }
            catch (Exception)
            {
                MessageBox.Show("Hibás választás", "Hiba");
            }
        }

        private void rdNev_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void rdEredmeny_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Sorted = false;
            listBox1.Items.Clear();
            Versenyzo temp;
            for (int i = 0; i < versenyzok.Count-1; i++)
            {
                for (int j = 0; j < versenyzok.Count; j++)
                {
                    if (versenyzok[i].IdoEredmeny > versenyzok[j].IdoEredmeny)
                    {
                        temp = versenyzok[i];
                        versenyzok[i] = versenyzok[j];
                        versenyzok[j] = temp;
                    }
                }
            }
            foreach (Versenyzo versenyzo in versenyzok)
            {
                listBox1.Items.Add(versenyzo);
            }
        }

        private void btnOrszagok_Click(object sender, EventArgs e)
        {
            ZaszloForm zaszloForm = new ZaszloForm();
            zaszloForm.Fogad(versenyzok);
            zaszloForm.ShowDialog();
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan Kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }
    }
}
