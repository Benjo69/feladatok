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
    public partial class SzamlaForm : Form
    {
        public SzamlaForm()
        {
            InitializeComponent();
        }

        internal void Kitolt(List<Ital> italok)
        {
            rchTxtSzamla.Clear();
            foreach (Ital item in italok)
            {
                if (item.Mennyiseg != 0)
                {
                    rchTxtSzamla.Text += item.ToString() + "\r\n";
                }
            }
        }
    }
}
