using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Büfe_Satış_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasaTutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;

            misir = Convert.ToInt32(txtMisir.Text);
            su = Convert.ToInt32(txtSu.Text);
            cay = Convert.ToInt32(txtCay.Text);
            bilet = Convert.ToInt32(txtBilet.Text);

            toplam = (misir * 10) + (su * 2) + (cay * 4) + (bilet * 30);
            lblToplam.Text = toplam.ToString() + " TL";

            kasaTutar += toplam;
            lblKasa.Text = kasaTutar.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBilet.Text = "";
            txtCay.Text = "";
            txtMisir.Text = "";
            txtSu.Text = "";

            txtMisir.Focus();
        }
    }
}
