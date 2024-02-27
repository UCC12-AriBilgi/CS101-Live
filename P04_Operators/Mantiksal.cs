using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Operators
{
    internal class Mantiksal
    {
        public static void Main(string[] args)
        {
            // Bu operatörler true/false(doğru-yanlış) olarak çalışan ve değişgenleri mantıksal olarak ve(&&), veya(||), değil(!) gibi işlemlere sokarlar. 

            bool D = 35 > 10 && 10 == 50; // false

            bool E = 35 > 10 && 10 != 50; // true

            bool F = 5 is int || 12 * 3 == 200; // true

            bool G = 5 < 4 || 45 / 5 == 9; // true

            Console.WriteLine("Sonuc :\n{0}\n{1}\n{2}\n{3}\n",D,E,F,G);

            Console.ReadKey();
        }
    }
}
