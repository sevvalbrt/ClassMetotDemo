using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        List<Musteri> musteriler = new List<Musteri>();

        public void Ekle(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi+" isimli müşteri eklendi.");
        }

        
        public void Listele()
        {
            
            foreach (var musteri in musteriler)
            {
                
                Console.WriteLine(musteri.Adi + " " + musteri.Soyadi);
            }
            
        }

        public void Sil(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine("\nSilinen Müşteri: " + musteri.Adi + " " + musteri.Soyadi);
            Console.WriteLine("\nGüncel Müşteri Listesi");
            Console.WriteLine("----------------------");
            Listele();
        }
    }
}
