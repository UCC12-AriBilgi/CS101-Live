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
            #region for / foreach döngülerinin kullanımı
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

            int[] sayilar = {4,5,-15,22,-34,3,0,43,100 };

            // foreach kullanın


            #endregion




            Console.ReadKey();
        }
    }
}
