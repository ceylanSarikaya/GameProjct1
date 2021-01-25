using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjct1
{
    class Oyuncu : IOyuncuManager
    {
        IOyuncuKontrolServisi _oyuncuKontrolServisi; //Dependency Injection

        public Oyuncu(IOyuncuKontrolServisi oyuncuKontrolServisi)  
        {
         
            _oyuncuKontrolServisi = oyuncuKontrolServisi;
        }

        public void Ekle(OyuncuBilgi oyuncuBilgi)
        {
            if (_oyuncuKontrolServisi.KontrolEt(oyuncuBilgi))
            {
                Console.WriteLine(oyuncuBilgi.OyuncuAdi + " Oyuncu Doğrulandı ve Eklendi !");
            }
            else 
            {
                Console.WriteLine("Oyuncu doğrulanamadı !"); //false dönüceği için bu blok çalışacak.
            }
       
        }

        public void Guncelle(OyuncuBilgi oyuncuBilgi)
        {
            Console.WriteLine(oyuncuBilgi.OyuncuAdi +   " Oyuncu Guncellendi");
        }

        public void Sil(OyuncuBilgi oyuncuBilgi)
        {
            Console.WriteLine(oyuncuBilgi.OyuncuAdi + " Oyuncu Silindi");
        }
    }
}

