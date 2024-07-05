using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retoxikáló
{
    public partial class ItalLapForm : Form
    {
        public ItalLapForm()
        {
            InitializeComponent();
        }

        private List<Ital> italok = new List<Ital>();
        private List<CheckBox> chkBoxok = new List<CheckBox>();
        private List<TextBox> txtBoxok = new List<TextBox>();
        private int bal = 10, fent = 10, chkXMeret = 250, chkYTav = 40, txtXMeret = 30, txtYMeret = 17, xKoz = 5;

        private void fizetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Ital item in italok)
            {
                item.Fizet();
            }
        }

        private void szamlatKerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SzamlaForm szlaForm = new SzamlaForm();
            szlaForm.Kitolt(italok);
            szlaForm.ShowDialog();
        }

        private void btnRendel_Click(object sender, EventArgs e)
        {
            bool valasztott = false, vanHibasAdag = false;
            int mennyiseg = 0;

            for (int i = 0; i < chkBoxok.Count; i++)
            {
                if (chkBoxok[i].Checked)
                {
                    valasztott = true;
                    try
                    {
                        mennyiseg = int.Parse(txtBoxok[i].Text);
                        if (mennyiseg <= 0 || mennyiseg > maxAdag) throw new Exception();
                        italok[i].Rendel(mennyiseg);
                        txtBoxok[i].BackColor = Color.White;
                        chkBoxok[i].Checked = false;
                        txtBoxok[i].Clear();
                    }
                    catch (Exception)
                    {
                        txtBoxok[i].BackColor = Color.Salmon;
                        vanHibasAdag = true;
                    }
                }
            }
            if (!valasztott)
            {
                MessageBox.Show("Semmit sem választott!", "figyelmeztetés");
            }else if ( vanHibasAdag){
                MessageBox.Show("A pirossal jelzett adagok hibásak", "figyelmeztetés");
            }
        }

        private int maxAdag = 999;
        internal void ArlapotIr(List<Ital> italok)
        {
            panel1.Controls.Clear();
            chkBoxok.Clear();
            txtBoxok.Clear();
            this.italok = italok;

            CheckBox chkBox;
            TextBox txtBox;
            Label lbl;

            for (int i = 0; i < italok.Count; i++)
            {
                chkBox = new CheckBox();
                txtBox = new TextBox();
                lbl = new Label();
                
                chkBox.Location = new Point(bal, fent + i * chkYTav);
                chkBox.Size = new Size(chkXMeret, txtYMeret);
                chkBox.Text = italok[i].Arlistaba();
                chkBox.TextAlign = ContentAlignment.MiddleLeft;

                txtBox.Location = new Point(bal + chkXMeret, fent + i * chkYTav - 2);
                txtBox.Size = new Size(txtXMeret, txtYMeret);

                lbl.AutoSize = true;
                lbl.Location = new Point(bal + chkXMeret + txtXMeret + xKoz, fent + i * chkYTav + 1);
                lbl.Text = "adag";
                panel1.Controls.Add(chkBox);
                panel1.Controls.Add(txtBox);
                panel1.Controls.Add(lbl);
                chkBoxok.Add(chkBox);
                txtBoxok.Add(txtBox);
            }
        }

    }
}
