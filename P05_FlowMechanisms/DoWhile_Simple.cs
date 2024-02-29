using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_FlowMechanisms
{
    internal class DoWhile_Simple
    {
        public static void Main(string[] args)
        {
            // 1..100 arası sayıların toplamının do..while yapımı

            int toplam = 0;
            int sayi = 1;

            do
            {
                toplam += sayi; // toplam= toplam + sayi

                sayi++;

            } while (sayi <=100);

            Console.WriteLine($"Toplam : {toplam}");


            Console.ReadKey();
        }

    }
}
