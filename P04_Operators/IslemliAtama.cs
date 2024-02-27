using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Operators
{
    internal class IslemliAtama
    {
        public static void Main(string[] args)
        {
            // ++ +1 yapıyor

            // += operatörü
            // kullanıldığı yere göre operatörün sağındaki değişgen/değer ile solundaki değişgen değerini toplayıp tekrardan soldaki değişgene atama işlemi için kullanılır.
            // 
            // yani a= a + b => a += b, a-=b, a*=b, a/=b

            int x2 = 0;
            x2 += 15; // ==> x2=x2 + 15

            int y2 = 0;
            y2 += 3;

            x2 += y2; // x2= x2 + y2
            Console.WriteLine("Değer = {0}",x2);
            Console.WriteLine($"Değer(+=) = x değeri {x2} y değeri {y2}\n\n");

            // -=

            int x1 = 10;
            int y1 = 5;

            x1 -= y1; // ==> x1= x1-y1
            y1 -= x1;

            Console.WriteLine($"Değer(-=) = x değeri {x1} y değeri {y1}");







            Console.ReadKey();
        }
    }
}
