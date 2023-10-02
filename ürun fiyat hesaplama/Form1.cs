using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ürun_fiyat_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt32(txtFiyat.Text);
            int Miktar = Convert.ToInt32(txtMiktar.Text);
             
            int tutar= fiyat * Miktar;

            lblTutar.Text = tutar.ToString();   
        }
    }   
}
