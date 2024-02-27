using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Operators
{
    internal class Ternary
    {
        public static void Main(string[] args)
        {
            // ?:
            // 3 operand alan tek operatör. Verilen bir koşula göre koşula giren değerlerden(object türünden) birini seçer/tutar

            Console.WriteLine("C# amcayı sevdiniz mi ki ne? (e,h) : ");

            string cevap=Console.ReadLine(); // ekrandan klavyeden bilgi okuma

            Console.WriteLine(cevap == "e" ? "Güzel..hoş..": "E napalım bi daaki bahara" + "\n\n" );

            Console.ReadKey();
        }
    }
}
