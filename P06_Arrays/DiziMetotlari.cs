using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Arrays
{
    internal class DiziMetotlari
    {
        public static void Main(string[] args)
        {
            #region Dizilerde kullanılan bazı metotlar
            //GetLength

            //int[] sayilar1 = { 1, 2, 4, 87, 56, 76 };
            //int[] sayilar2 = { 43, 67, 456, 3, 7 };
            //Console.WriteLine("sayılar1 dizisinin boyutu,(GetLenght metodu ile) : " + sayilar2.GetLength(0) + "\n\n"); // 0 parametresi dizi boyutunu gösteriyor.
            //Console.WriteLine("sayılar1 dizisinin boyutu (Length metodu ile) : " + sayilar2.Length);

            // Çok boyutlu dizi tanımlama(dizi içinde dizi)
            //int[,] sayilar3 = { {2,4,3,7,5 },{4,7,12,17,4 },{12,54,78,45,30 } };
            //// 3x4 lük bir dizi var karsımda

            //byte boyut3 = (byte)sayilar3.GetLength(1);


            //Console.WriteLine($"sayilar3 dizi boyutu : {boyut3}");


            #endregion

            #region diğer bir kullanım

            //int[][] dizi16 = new int[3][];

            //dizi16[0] = new int[] { 1, 2, 3 };
            //dizi16[1] = new int[] { 4,5,6,7 };
            //dizi16[2] = new int[] { 8, 9 };

            //// dizinin bütün elemanlarını teker teker ekrana yazdıran pp

            //for (int i = 0; i < dizi16.GetLength(0); i++)
            //    for (int j = 0; j < dizi16[i].GetLength(0); j++)
            //        //Console.WriteLine("dizi16[{0}][{1}]={2}", i, j, dizi16[i][j]);
            //        Console.WriteLine($"dizi16[{i}][{j}]={dizi16[i][j]}");


            #endregion

            #region Create Instanse

            // int türünden 5 elemanlı dizi17 isimli bir dizi yaratımı

            //Array dizi17 = Array.CreateInstance(typeof(int), 5);

            //// int türünden 3x2x5 boyutunda 3 boyutlu dizi yaratımı
            //Array dizi18 = Array.CreateInstance(typeof(int), 3,2,5);

            //// ilginç bir kullanım...yaratılırken ilk değerlerin atanması
            //int[] dizi19 = new int[5] { 2, 3, 4, 5, 6 };

            //// Gerçekten ilginç

            //// dizi20 int ve 2x3x4x5x6 olarak 5 boyutlu dinamik bir hal aldı
            //Array dizi20 = Array.CreateInstance(typeof(int), dizi19);

            #endregion

            #region Dizi kopyalama
            //int[] dizi22 = { 1, 2, 3, 4 }; 
            //int[] dizi23 = new int[10];

            //dizi22.CopyTo(dizi23, 3); // dizi22 nin tüm elemanları dizi23 e 3.indekten itibaren kopyalanıyor

            ////*

            //int[] dizi24 = { 1, 2, 3, 4 };
            //int[] dizi25 = new int[10];

            //Array.Copy(dizi24,dizi25,3); // Koplama işlemi 0.indekten normalde baslar. Burada 3 tane eleman dizi24 -> dizi25 e kopyalanıyor.

            #region Dizi sıralama

            Array sehirler = Array.CreateInstance(typeof(string), 8);

            sehirler.SetValue("İstanbul", 0);
            sehirler.SetValue("Ankara", 1);
            sehirler.SetValue("İzmir", 2);
            sehirler.SetValue("Bursa", 3);
            sehirler.SetValue("Adıyaman", 4);
            sehirler.SetValue("Muğla", 5);
            sehirler.SetValue("Trabzon", 6);
            sehirler.SetValue("Rize", 7);

            Console.WriteLine("Sırasız halde dizi\n\n");

            foreach (string sehir in sehirler)
                Console.Write(sehir + " ");

            Console.WriteLine("");

            Console.WriteLine("Alfabetik Sıralı halde dizi (A-Z)\n\n");

            Array.Sort(sehirler);

            foreach (string sehir in sehirler)
                Console.Write(sehir + " ");

            Console.WriteLine("");
            Console.WriteLine("Alfabetik Sıralı halde dizi (Z-A)\n\n");

            Array.Reverse(sehirler);

            foreach (string sehir in sehirler)
                Console.Write(sehir + " ");

            // hack
            // dizim bu sefer 10 elemanlı sayısal bir dizi olsun..eleman değerleri size ait...önce karışık,sonra artan sırada sonra da azalan sırada ekrana yazdırma..


            #endregion










            #endregion




            Console.ReadKey();
        }
    }
}
