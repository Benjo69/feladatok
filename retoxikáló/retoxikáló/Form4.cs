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
    public partial class GaleriaForm : Form
    {
        public GaleriaForm()
        {
            InitializeComponent();
        }
        private List<Image> kepek = new List<Image>();
        private int aktualisIndex;

        internal void Atad(List<Image> kepek)
        {
            this.kepek = kepek;
            pictureBox1.Image = kepek[aktualisIndex];
        }

        private void btnJobb_Click(object sender, EventArgs e)
        {
            if (aktualisIndex < kepek.Count - 1) aktualisIndex++;
            else aktualisIndex = 0;
            pictureBox1.Image = kepek[aktualisIndex];
        }

        private void btnBal_Click(object sender, EventArgs e)
        {
            if (aktualisIndex > 0) aktualisIndex--;
            else aktualisIndex = kepek.Count - 1;
            pictureBox1.Image = kepek[aktualisIndex];
        }
    }
}
