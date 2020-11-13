using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAraba_Odev
{
    class Bilgiler
    {
        //Id
        //Marka
        //Model
        //KapiSayisi(2 kapılı, 4 kapılı, 5 kapılı)
        //BeygirGucu(Beygir cinsinden)
        //ArabaTuru(Binek, Ticari)
        //MaksimumHiz(Kilometre/saat cinsinden)
        //Cekis(Önden çekiş, Arkadan itiş, Dört çeker)
        //SifirdanYuzeHizlanma(Saniye cinsinden)
        //Agirlik(Kilogram cinsinden)
        //MotorHacmi(Santimetreküp cinsinden)
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public byte KapiSayisi { get; set; }
        public int BeygirGucu { get; set; }
        public TurEnum Turu { get; set; }
        public int MaksimumHiz { get; set; }
        public string Cekis { get; set; }
        public double SifirdanYuzeHizlanma { get; set; }
        public int Agirlik { get; set; }
        public int MotorHacmi { get; set; }
    }
}
