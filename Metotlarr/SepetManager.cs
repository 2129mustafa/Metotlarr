using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlarr
{
    //operasyon
    class SepetManager
    {
        public void Add(Urun urun) //burya ekleyeceğimiz urunun prametrseni gönderdik.
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : "+urun.Adi);
        }
        public void Add2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi: "+urunAdi);
        }
    }
}
