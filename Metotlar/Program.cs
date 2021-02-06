using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Urun urun1=new Urun();
            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };


            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.UrunAdi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------------");
            }
            Console.WriteLine("-------------Metotlar---------------------");
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle( urun1 );
            sepetManager.Ekle( urun2 );
           

        }
    }
}
