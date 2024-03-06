using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Functions
{
    internal class StringFunctions
    {
        public static void Main(string[] args)
        {
            #region Length
            //string metin = "\tArı Bilgi Yazılım Eğitimi";

            //// boşluklar da dahil....
            //Console.WriteLine($"Metin : {metin}");
            //Console.WriteLine($"Metnin uzunluğu : {metin.Length}");


            #endregion

            #region ToLower/ToUpper

            //Console.WriteLine($"Metnin küçük hali : {metin.ToLower()}");
            //Console.WriteLine($"Metnin büyük hali : {metin.ToUpper()}");

            #endregion


            #region Concat - Concatenate
            //string metin1=Console.ReadLine();
            //string metin2=Console.ReadLine();

            //string sonuc = String.Concat(metin1," ","\t", metin2);   
            //Console.WriteLine($"Concat sonrası : {sonuc}");


            #endregion

            #region Compare - Karşılaştırma
            // iki string bilginin karşılastırılması için kullanılır
            // string ifadelerin 1.karakterinden itibaren karakter-karakter karşılastırma işlemi yapar. Ve buna göre geriye bir tamsayı değer döndürür. Eğer geriye dönen değer;

            // 0 ise : metinler tamamen aynıdır.
            // 1 ise : 1.metnin karşılıştırılan karakteri diğer karşılastırılan karakterden büyük olduğu anlasılıyor (metin1 > metin2)
            // -1 ise : 1.metnin karşılıştırılan karakteri diğer karşılastırılan karakterden küçük olduğu anlasılıyor (metin1 < metin2)

            // Compare metodu büyük-küçük harfe duyarlı/duyarsız olarak çalışması düzenlenebilir

            // Eğer böyle bir özellik verilmek istenirse Compare metoduna 3. bir parametre eklenir ve bu parametre boolean(true-false) verilir.
            // Eğer;
            // true ise : büyük-küçük harf duyarsız olacaktır
            // false ise : büyük-küçük harf duyarlı olacaktır

            string metin1,metin2;

            metin1 = "MCSD"; //?
            metin2 = "MCSd"; //? ilk karakteri yakaladı mı gibi bir durum var sanki.

            int sonuc=string.Compare(metin1, metin2);

            int sonuc1=string.Compare(metin1, metin2,false);

            switch (sonuc1)
            {
                case 0:
                    Console.WriteLine("metin1 ve metin2 tamamen aynıdır...\n\n");
                    break;
                    case 1:
                    Console.WriteLine("metin1 metin2'den büyüktür...\n\n");
                    break;
                    case -1:
                    Console.WriteLine("metin1 metin2'den küçüktür...\n\n");
                    break;
                default:
                    break;
            }


            Console.ReadLine();






            #endregion






            Console.ReadKey();

        }
    }
}
