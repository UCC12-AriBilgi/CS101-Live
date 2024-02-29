using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_FlowMechanisms
{
    internal class While
    {
        public static void Main(string[] args)
        {
            #region while 1
            // 1-100 arasındaki sayıların toplamını ekrana yaz
            //int toplam = 0;
            //int sayi=1;

            //while (sayi <= 100) // bu kosul doğru olduğu surece {} arasını yap
            //{
            //    toplam = toplam + sayi;

            //    sayi++;
            //}

            //Console.WriteLine(toplam.ToString());


            #endregion

            #region while 2
            // Ekrandan girilen bir sayının basamaklarını bulan program parçası

            Console.WriteLine("Lütfen sayınızı giriniz :");

            ulong sayi=ulong.Parse(Console.ReadLine());
            ulong ysayi = sayi; // basta sakladım.

            int basamak=0; // Kaç basamaklı olduğunu tutacağım değişgen

            while (sayi > 0)
            {
                basamak++;


                sayi= sayi / 10;

            }

            Console.WriteLine($"Girdiğiniz sayı : {ysayi} ve {basamak} basamaklıdır...");


            #endregion

            Console.ReadKey();
        }


    }
}
