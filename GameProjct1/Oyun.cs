using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjct1
{
    class Oyun : IOyunManager

    {
        public void Ekle(OyunBilgi oyunBilgi)
        {
            Console.WriteLine(oyunBilgi.OyunAdi+" Eklendi");
        }

        public void Guncelle(OyunBilgi oyunBilgi)
        {
            Console.WriteLine(oyunBilgi.OyunAdi + " Güncellendi");
        }

        public void Sil(OyunBilgi oyunBilgi)
        {
            Console.WriteLine(oyunBilgi.OyunAdi + " Silindi");
        }
    }
}
