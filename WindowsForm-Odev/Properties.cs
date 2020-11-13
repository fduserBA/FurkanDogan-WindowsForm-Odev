using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_Odev
{
    public class Propertieses
    {
        public string Toplama(double sayi1, double sayi2)
        {
            double sonuc = sayi1 + sayi2;
            return sonuc.ToString();
        }
        public string Cıkarma(double sayi1, double sayi2)
        {
            double sonuc = sayi1 - sayi2;
            return sonuc.ToString();
        }
        public string Carpma(double sayi1, double sayi2)
        {
            double sonuc = sayi1 * sayi2;
            return sonuc.ToString();
        }
        public string Bolme(double sayi1, double sayi2)
        {
            double sonuc = sayi1 / sayi2;
            return sonuc.ToString();
        }
        public double TersAlma(double sayi)
        {
            double sonuc = 1 / sayi;
            return sonuc;
        }
        public double KareAlma(double sayi)
        {
            var sonuc = sayi * sayi;
            return sonuc;
        }
        public double KokAlma(double sayi)
        {
            var sonuc = Math.Sqrt(sayi);
            return sonuc;
        }
    }
}
