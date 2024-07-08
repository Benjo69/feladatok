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
    public partial class NevjegyForm : Form
    {
        private string keszito;
        public NevjegyForm(string keszito)
        {
            InitializeComponent();
            this.keszito = keszito;
        }

        private void NevjegyForm_Load(object sender, EventArgs e)
        {
            txtNevjegy.Text = "Készítette: " + keszito;
        }
    }
}
