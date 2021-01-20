using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Şevval";
            musteri1.Soyadi = "Barut";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Meral";
            musteri2.Soyadi = "Taşdemir";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Ayşe";
            musteri3.Soyadi = "Elgören";


            MusteriManager manager = new MusteriManager();
            manager.Ekle(musteri1);
            manager.Ekle(musteri2);
            manager.Ekle(musteri3);

            Console.WriteLine("\nMüşteri Listesi");
            Console.WriteLine("---------------");
            manager.Listele();

            manager.Sil(musteri1);
            Console.ReadLine();

        }
    }
}
