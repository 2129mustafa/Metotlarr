using System;

namespace Metotlarr
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("--------------- Metotlar ---------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(urun1);
            sepetManager.Add(urun2);


            sepetManager.Add2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Add2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Add2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
           
        }
    }
}
