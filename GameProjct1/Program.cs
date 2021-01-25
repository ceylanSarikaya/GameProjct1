using System;

namespace GameProjct1
{
    class Program
    {
        static void Main(string[] args)
        {
            OyuncuBilgi oyuncuBilgi1 = new OyuncuBilgi { TcNo = "12345678", DogumYili = "11.07.1999", OyuncuAdi = "Kerem", OyuncuSoyadi = "Bayrak" };
            OyuncuBilgi oyuncuBilgi2 = new OyuncuBilgi { TcNo = "89648333", DogumYili = "08.06.2001", OyuncuAdi = "Ayşe", OyuncuSoyadi = "Cavuş" };
            OyuncuBilgi oyuncuBilgi3 = new OyuncuBilgi {TcNo="16273384",DogumYili="03.03.2000",OyuncuAdi="Ali",OyuncuSoyadi="Mert" };

            OyunBilgi oyunBilgi1 = new OyunBilgi();
            oyunBilgi1.Id = 1;
            oyunBilgi1.StokAdedi ="3";
            oyunBilgi1.OyunAdi = "Satranç";
            oyunBilgi1.OyunHakinda= "Satranç, karşılıklı iki kişi arasında, satranç tahtası üzerinde, oyuna ait özel taşlar ile oynanan bir masa oyunu türüdür. " +
                "Dünya üzerinde büyük turnuvalar düzenlenir ve genellikle bir spor olarak kabul edilir. "+
                "Satranç tahtası adı verilen 8x8 ’lik kare bir zemin üzerinde, satranç taşları ile oynanır.";

            OyunBilgi oyunBilgi2 = new OyunBilgi();
            oyunBilgi2.Id = 2;
            oyunBilgi2.StokAdedi = "5";
            oyunBilgi2.OyunAdi = "Pubg Mobile";
            oyunBilgi2.OyunHakinda = "PUBG mobile , PlayerUnknown's Battlegrounds isimli mücadeleci First Person Shooter oyunun mobil versiyonu."+
                " Oyun, bir adaya uçakla bırakılan 100 oyuncunun arasında birinci olmayı hedeflemekte";

            OyunBilgi oyunBilgi3 = new OyunBilgi();
            oyunBilgi3.Id = 3;
            oyunBilgi3.StokAdedi = "7";
            oyunBilgi3.OyunAdi = "Zula";
            oyunBilgi3.OyunHakinda = "MMOFPS türünde Türk yapımı video oyunudur. Oyun Türkiye'den sonra ilk defa Brezilya'da, 2016 yılının Haziran ayında, Playspot firması tarafından yayımlanmıştır.." +
                " Zula, adlı internet sitesinden ücretsiz indirilip kayıt olunduktan sonra direkt oynanabilmektedir.";

         


            IOyuncuManager oyucu = new Oyuncu(new OyuncuKontrolYoneticisi());
            oyucu.Ekle(oyuncuBilgi1);
            oyucu.Guncelle(oyuncuBilgi2);
            oyucu.Sil(oyuncuBilgi3);
            Console.WriteLine("------------------");

           IOyunManager oyun = new Oyun();
           oyun.Ekle(oyunBilgi1);
           oyun.Guncelle(oyunBilgi2);
           oyun.Sil(oyunBilgi3);
           Console.WriteLine("------------------");
           IKampanyaLog kampanyalar = new KampanyalarServisi();
           kampanyalar.log();





        }
    }
}
