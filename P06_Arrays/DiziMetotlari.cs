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
            int[,] sayilar3 = { {2,4,3,7,5 },{4,7,12,17,4 },{12,54,78,45,30 } };
            // 3x4 lük bir dizi var karsımda

            byte boyut3 = (byte)sayilar3.GetLength(1);


            Console.WriteLine($"sayilar3 dizi boyutu : {boyut3}");


            #endregion




            Console.ReadKey();
        }
    }
}
