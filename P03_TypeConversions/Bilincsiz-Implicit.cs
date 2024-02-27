using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_TypeConversions
{
    internal class Bilincsiz_Implicit
    {
        // public..dış dunyaya acık
        public static void Main(string[] args)
        {
            // Tür dönüşüm örnekleri-Bilincsiz
            // 1
            byte a = 10;

            short b = 20;

            sbyte c = -30;

            int toplam = a + b + c; // bilincsiz tür donusumunu yaptım

            //2
            string e = "ARI Bilgi Project";

            char f= 'A';

            // içinde farklı tipleri bulundurabilen veri tipi
            object g = e + " " + f + " " + toplam;
            //3
            long h = toplam;

            float i = h;

            double j = i;

            double k = 21.6;

            Console.WriteLine("1.durum : " + toplam.ToString() + "\n\n");
            Console.WriteLine("2.durum : " + g.ToString() + "\n\n");
            Console.WriteLine("3.durum : " + h + k + "\n\n");






        }
    }
}
