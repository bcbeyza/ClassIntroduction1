using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1); // sayi1=30


            int[] sayilar = new int[] { 10, 20, 30 };
            int[] sayilar1 = new int[] { 100, 200, 300 };
            sayilar = sayilar1;
            sayilar1[0] = 999;
            Console.WriteLine(sayilar[0]);// sayilar[0]=999



        }


    }
}
