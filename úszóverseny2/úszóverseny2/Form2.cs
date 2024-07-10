using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace úszóverseny2
{
    public partial class VersenyForm : Form
    {
        public List<Versenyzo> Versenyzok { get; private set; }
        public string UszasNem { get; private set; }
        public int Tav { get; private set; }

        private DateTime alap = new DateTime(2000, 01, 01, 0, 0, 0);
        private int sorSzam;

        public VersenyForm()
        {
            InitializeComponent();
            dateTimePicker1.Value = alap;
            comboBox1.SelectedIndex = 0;
        }

        internal void Fogad(List<Versenyzo> versenyzok)
        {
            Versenyzok = versenyzok;
        }

        public void VersenyzoBeallitas()
        {
            dateTimePicker1.Value = alap;
            if (sorSzam < Versenyzok.Count)
            {
                textBox1.Text = Versenyzok[sorSzam].ToString();
            }
            else
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeSpan idoEredmeny = dateTimePicker1.Value - alap;
            Versenyzok[sorSzam].Versenyez(idoEredmeny);
            sorSzam++;
            VersenyzoBeallitas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            comboBox1.Enabled = false;
            numericUpDown1.Enabled = false;
            button1.Enabled = false;

            UszasNem = comboBox1.SelectedIndex.ToString();
            Tav = Convert.ToInt32(numericUpDown1.Value);
        }
    }
}