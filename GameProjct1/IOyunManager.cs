using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjct1
{
    interface IOyunManager
    {
        void Ekle(OyunBilgi oyunBilgi);
        void Guncelle(OyunBilgi oyunBilgi);
        void Sil(OyunBilgi oyunBilgi);

    }

    interface IOyuncuManager
    {
        void Ekle(OyuncuBilgi oyuncuBilgi);
        void Guncelle(OyuncuBilgi oyuncuBilgi);
        void Sil(OyuncuBilgi oyuncuBilgi);


    }
}
