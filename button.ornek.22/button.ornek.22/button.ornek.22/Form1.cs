using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._22
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double fiyat = Convert.ToDouble(txtFiyatGir.Text);
            double odenecek = 0;
            if (rb5.Checked)
            {
                odenecek = fiyat;
            }
            else if (rb5.Checked)
            {
                odenecek = fiyat * 0.95;
            }
            else if (rb30.Checked)
            {
                odenecek = fiyat * 0.70;
            }
            else
            {
                odenecek = fiyat * 0.60;
            }
            lblOdenecek.Text=odenecek.ToString()+"₺";
                
        }
    }
}
