using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPAraba_Odev
{
    public partial class Form1 : Form
    {
        Bilgiler bilgiler;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bilgiler = new Bilgiler();
            bilgiler.Marka = tbMarka.Text;
            bilgiler.Model = tbModel.Text;
            bilgiler.KapiSayisi = Convert.ToByte(cbKapiSayisi.Text);
            bilgiler.BeygirGucu = Convert.ToInt32(tbBeygirGucu.Text);
            if (rbBinek.Checked)
                bilgiler.Turu = TurEnum.Binek;
            else if (rbTicari.Checked)
                bilgiler.Turu = TurEnum.Ticari;
            else
                MessageBox.Show("Arabanın türünü seçiniz!");
            bilgiler.MaksimumHiz = Convert.ToInt32(tbMaksimumHız.Text);
            bilgiler.Cekis = cbCekis.Text;
            bilgiler.SifirdanYuzeHizlanma = Convert.ToDouble(tbIvme.Text);
            bilgiler.Agirlik = Convert.ToInt32(tbAgirlik.Text);
            bilgiler.MotorHacmi = Convert.ToInt32(tbMotorHacmi.Text);
            MessageBox.Show("Kaydedildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string line = bilgiler.Marka + "\n" + bilgiler.Model + "\n" + bilgiler.KapiSayisi + "\n" + bilgiler.BeygirGucu + "\n" + bilgiler.Turu + "\n" + bilgiler.MaksimumHiz;
            line += bilgiler.Cekis + "\n" + bilgiler.SifirdanYuzeHizlanma + "\n" + bilgiler.Agirlik + "\n" + bilgiler.MotorHacmi;
            lSonuc.Text = line;
        }
    }
}
