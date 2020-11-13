using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesliSessizHarf_Odev
{
    class Islem
    {
        string _sesliHarfler = "", _sessizHarfler = "";
        int _sesliHarfSayisi = 0, _sessizHarfSayisi = 0;
        char[] _tumSessizHarfler = { 'b', 'c', 'd', 'f', 'g', 'ğ', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'ş', 't', 'v', 'w', 'y', 'z' };
        char[] _tumSesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        public string SesliHarfSorgu(string metin)
        {
            foreach (var harf in _tumSesliHarfler)
            {
                if (metin.Contains(harf))
                {
                    _sesliHarfler += "/" + harf;
                }
                else
                {

                }
            }
            return _sesliHarfler;
        }
        public string SessizHarfSorgu(string metin)
        {
            foreach (var harf in _tumSessizHarfler)
            {
                if (metin.Contains(harf))
                {
                    _sessizHarfler += "/" + harf;
                }
                else
                {

                }
            }
            return _sessizHarfler;
        }
        public string SesliHarfSayiSorgu(string metin)
        {
            foreach (var harf in metin)
            {
                if (_tumSesliHarfler.Contains(harf))
                {
                    _sesliHarfSayisi += 1;
                }
                else
                {

                }
            }
            return _sesliHarfSayisi.ToString();
        }
        public string SessizHarfSayiSorgu(string metin)
        {
            foreach (var harf in metin)
            {
                if (_tumSessizHarfler.Contains(harf))
                {
                    _sessizHarfSayisi += 1;
                }
                else
                {

                }
            }
            return _sessizHarfSayisi.ToString();
        }
    }
}
