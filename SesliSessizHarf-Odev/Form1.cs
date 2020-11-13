using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SesliSessizHarf_Odev
{
    public partial class Form1 : Form
    {
        Islem islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            islem = new Islem();
            switch (cbHarfGetiren.Text)
            {
                case "Seçiniz":
                    MessageBox.Show("Harf türü seçilmedi!");
                    break;
                case "Sesli Harfler":
                    lSonuc.Text = islem.SesliHarfSorgu(tbGiris.Text) + " /Sesli harf sayısı: " + islem.SesliHarfSayiSorgu(tbGiris.Text);
                    break;
                case "Sessiz Harfler":
                    lSonuc.Text = islem.SessizHarfSorgu(tbGiris.Text) + " /Sessiz harf sayısı: " + islem.SessizHarfSayiSorgu(tbGiris.Text);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbHarfGetiren.Items.Insert(0, "Seçiniz");
            cbHarfGetiren.Items.Insert(1, "Sesli Harfler");
            cbHarfGetiren.Items.Insert(2, "Sessiz Harfler");
        }
    }
}
