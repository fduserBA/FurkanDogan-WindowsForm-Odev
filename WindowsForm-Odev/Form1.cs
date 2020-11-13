using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Propertieses propertieses = new Propertieses();
        #region SayiButonlari
        private void b1_Click(object sender, EventArgs e)
        {
            double sayi1 = 1;
            tbGiris.Text += sayi1.ToString();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            double sayi2 = 2;
            tbGiris.Text += sayi2.ToString();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            double sayi3 = 3;
            tbGiris.Text += sayi3.ToString();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            double sayi4 = 4;
            tbGiris.Text += sayi4.ToString();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            double sayi5 = 5;
            tbGiris.Text += sayi5.ToString();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            double sayi6 = 6;
            tbGiris.Text += sayi6.ToString();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            double sayi7 = 7;
            tbGiris.Text += sayi7.ToString();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            double sayi8 = 8;
            tbGiris.Text += sayi8.ToString();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            double sayi9 = 9;
            tbGiris.Text += sayi9.ToString();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            double sayi0 = 0;
            tbGiris.Text += sayi0.ToString();
        }

        private void bPi_Click(object sender, EventArgs e)
        {
            double pi = 3.1415926535;
            tbGiris.Text += pi.ToString();
        }
        #endregion

        private void bTersi_Click(object sender, EventArgs e)
        {
            tbGiris.Text = propertieses.TersAlma(Convert.ToDouble(tbGiris.Text)).ToString();
        }

        private void bKare_Click(object sender, EventArgs e)
        {
            tbGiris.Text = propertieses.KareAlma(Convert.ToDouble(tbGiris.Text)).ToString();
        }

        private void bKok_Click(object sender, EventArgs e)
        {
            tbGiris.Text = propertieses.KokAlma(Convert.ToDouble(tbGiris.Text)).ToString();
        }

        private void bBolu_Click(object sender, EventArgs e)
        {
            tbIlkGiris.Text = tbGiris.Text;
            tbGiris.Text = "";
            tbIslem.Text = "/";
        }

        private void bCarp_Click(object sender, EventArgs e)
        {
            tbIlkGiris.Text = tbGiris.Text;
            tbGiris.Text = "";
            tbIslem.Text = "x";
        }

        private void bCıkar_Click(object sender, EventArgs e)
        {
            tbIlkGiris.Text = tbGiris.Text;
            tbGiris.Text = "";
            tbIslem.Text = "-";
        }

        private void bTopla_Click(object sender, EventArgs e)
        {
            tbIlkGiris.Text = tbGiris.Text;
            tbGiris.Text = "";
            tbIslem.Text = "+";
        }

        private void bSonuc_Click(object sender, EventArgs e)
        {
            switch (tbIslem.Text)
            {
                case "/":
                    tbGiris.Text = propertieses.Bolme(Convert.ToDouble(tbIlkGiris.Text), Convert.ToDouble(tbGiris.Text));
                    break;
                case "x":
                    tbGiris.Text = propertieses.Carpma(Convert.ToDouble(tbIlkGiris.Text), Convert.ToDouble(tbGiris.Text));
                    break;
                case "+":
                    tbGiris.Text = propertieses.Toplama(Convert.ToDouble(tbIlkGiris.Text), Convert.ToDouble(tbGiris.Text));
                    break;
                case "-":
                    tbGiris.Text = propertieses.Cıkarma(Convert.ToDouble(tbIlkGiris.Text), Convert.ToDouble(tbGiris.Text));
                    break;
            }
            tbIlkGiris.Text = "";
            tbIslem.Text = "";
        }

        private void bVirgul_Click(object sender, EventArgs e)
        {
            tbGiris.Text += ",";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string SonDeger = tbGiris.Text.Remove(tbGiris.Text.Length - 1);
            tbGiris.Text = SonDeger;
        }
    }
}
