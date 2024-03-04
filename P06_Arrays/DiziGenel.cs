using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Arrays
{
    internal class DiziGenel
    {
        public static void Main(string[] args)
        {
            #region Dizi tanımlama, değer atama,kullanma

            int[] sayilar = new int[20]; // 20 elemanlık sayilar isminde bir dizi tanımı
            string[] names = new string[20]; // 20n elemanlık string bir dizi ismi de names

            // bir değer atama
            sayilar[5] = 30;

            names[10] = "Ümit";
            names[11] = "59";

            Console.WriteLine("Sayısal dizi sayilar'ın 5.indexindeki değer {0}", sayilar[5]);
            
            Console.WriteLine("Metinsel dizi names'in 10.indexindeki değer {0}", names[10]);
            Console.WriteLine("Metinsel dizi names'in 11.indexindeki değer {0}", names[11]);

            int sayi1 = sayilar[5];
            int sayi2 = Convert.ToInt32(names[11]);


            Console.WriteLine("Toplam {0}", sayi1 + sayi2);

            // Tanımlamalar Şöyle de olabilir
            string[] sayilarAlfa = { "Bir", "İki", "Üç", "Dört" }; // daha tanımlanırken initial değerlerin belirlenmesi

            int[] sayilar2 = { 1, 2, 3, 4, 5 };

            float[] sayilar3 = { 2f, 1.2f, 7f };

            // Fekat bu şekilde dizi tanımlamaları sadece dizi ilk tanımlarken yapabiliriz. Örneğin asağıdaki gibi bir kullanım hata verecektir.
            //int[] sayilar4
            //sayilar4= {5,7,89,98 };












            #endregion




            Console.ReadKey();
        }
    }
}
