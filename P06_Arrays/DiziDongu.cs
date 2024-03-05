using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Arrays
{
    internal class DiziDongu
    {
        public static void Main(string[] args)
        {
            #region for / foreach döngülerinin kullanımı (Hack01)
            // Verilen bir tamsayı dizisinin elemanlarının toplamını
            // hem for hem de foreach döngülerini kullanarak ayrı ayrı geliştiriniz.

            //for
            //int[] sayilar1 = { 5, 6, 7, 8, 78, 45, 0, 30 };
            //int toplam1 = 0; // toplamı tutacak

            //for (int index = 0; index < sayilar1.Length; index++)
            //{
            //    toplam1 += sayilar1[index]; // anında atama...sayilar1 dizisinin indexinci elemanını değeri al toplama ekle
            //}

            //Console.WriteLine($"for çevrimiyle elde edilen sonuç : {toplam1}");

            //// foreach ile
            //int toplam2 = 0;

            //foreach (int deger  in sayilar1)
            //{
            //    toplam2+= deger;
            //}

            //Console.WriteLine($"foreach çevrimiyle elde edilen sonuç : {toplam2}");

            #endregion

            #region Hack02
            // Tanımlanan sayısal bir dizi içersindeki sayıların negatif,pozitif,nötr olma durumlarını sayının yanına yazan program parçacığını geliştiriniz.
            // Örnek
            // 0    Nötr
            // 5    Pozitif
            // -7   Negatif
            //...
            // şeklinde

            // Hack02 ye ek..
            // Bir de acaba pozitifden,negatiften,nötr den kacar tane var..Bunları da çıkışta görebilelim
            // Pozitiflerin adedi : .... tane
            // Negatiflerin adedi : .... tane
            // Nötrlerin adedi : ... tane
            // diye

            //int[] sayilar = {4,5,-15,22,-34,3,0,43,100 };
            //int negadet = 0;
            //int pozadet = 0;
            //int notradet = 0;

            //// foreach kullanın
            //foreach (int sayi in sayilar)
            //{
            //    // gelen sayinın büyük 0 mı küçük 0 mı olduğunu anlamam lazım ki yanına hangi türden olduğunu yazabileyim.

            //    if (sayi > 0)
            //    {
            //        Console.WriteLine(sayi + "\tPozitifdir..");
            //        pozadet++;
            //    }

            //    else if (sayi < 0)
            //    {
            //        Console.WriteLine(sayi + "\tNegatifdir..");
            //        negadet++;
            //    }
            //    else
            //    {
            //        Console.WriteLine(sayi + "\tNötrdür..");
            //        notradet++;
            //    }
            //}

            //Console.WriteLine($"Pozitif sayıların adedi : {pozadet}");
            //Console.WriteLine($"Negatif sayıların adedi : {negadet}");
            //Console.WriteLine($"Nötr sayıların adedi : {notradet}");

            #endregion

            #region Hack03
            //Kullanıcıdan alınan bir metin içindeki sesli harf sayısını bulan ve bulduklarını baska bir diziye yerlestiren p.parçacığını tasarlayınız.

            // Öncelike seslilerin olduğu bir dizi tanımı yapıyorum.
            //char[] sesliler = {'a','e','ı','i','o','ö','u','ü' };

            //// Bulacağım seslileri yerleştireceğim bir dizi
            //char[] hangileri = new char[20];


            //string metin = ""; // ekrandan alacağım metin bilgisi
            //int hindex = 0; // hangileri dizisinin index bilgisini tutacak
            //int adet = 0; // bulduğum sesli harf adedini tutacak.

            //Console.WriteLine("Lütfen metni giriniz :");
            //metin = Console.ReadLine().ToLower();
            //// Büyük harf girse bile küçüğe çevirdim

            //// Not : aslında geriplanda metin bilgisi de bir dizi gibi algılabilir

            //// sesliler diziyle işe başlayacağız.
            //// 1.for cevrimi sesliler dizisi üzerinde hareket edecek
            //for (int sesliindex = 0; sesliindex < sesliler.Length ; sesliindex++)
            //{
            //    // 2.for çevrimi metin bilgisi için
            //    // metinin basından sonuna kadar ilerlenicek
            //    for (int metinindex = 0; metinindex < metin.Length; metinindex++)
            //    {
            //        // eğer metin içindekiş bir karakter benim sesli içindeki karaktere uyuyor mu
            //        if (metin[metinindex] == sesliler[sesliindex])
            //        {
            //            // baska bir diziye tasıyayım.
            //            hangileri[hindex] = metin[metinindex];//bulduğum sesli harfin ne olduğunu metin[metinindex] ile bilebiliyorum.
            //            hindex++; // birsonraki eleman için

            //            adet++; // Bulduğum sesli harf adedini artırıyorum
            //        }
            //    }

            //    // İç içe for olayında en önce içteki for biter sonra dıştaki for a dönülür ve o biter
            //}

            //Console.WriteLine($"Girmiş olduğunuz metinde {adet} adet sesli harf vardır\n\n");
            //Console.WriteLine(hangileri);

            #endregion

            #region Hack04

            // Verilen {4,5,-54,-76,-98,3,0,212,-313} dizisi içersindeki çift sayıların hatta uğrasabilirseniz tek sayıların da kaçar adet olduğunu ekrana yazdıran pp yi geliştiriniz...
            int[] sayilar = { 4, 5, 54, 76, 98, 3, 0, 212, 313 };
            int ciftadet = 0; // cift sayı adedinin tutulduğu değişgen
            int tekadet = 0; // tek sayılar için


            // foreach kullanın
            foreach (int sayi in sayilar)
            {

                if (sayi % 2 == 0) // mod işlemi uygulayarak kalanın kac olduğunu anlıyorum
                {
                    Console.WriteLine(sayi + "\tÇift sayı..");
                    ciftadet++;
                }
                else
                {
                    Console.WriteLine(sayi + "\tTek sayı..");
                    tekadet++;
                }
            }

            Console.WriteLine($"Çift sayıların adedi : {ciftadet}");
            Console.WriteLine($"Tek sayıların adedi : {tekadet}");




            #endregion

            Console.ReadKey();
        }
    }
}
