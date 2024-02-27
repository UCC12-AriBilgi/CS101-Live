using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_TypeConversions
{
    public class Bilincli_Explicit
    {
        public static void Main(string[] args)
        {
            int r = 15;

            byte s=(byte)r; // tip değeri yüksek olanı alçak olana alabildim. çünkü sayısal olarak küçük bir değere sahip

            Console.WriteLine("Toplam : " + (s+r));

            Console.WriteLine(r.ToString());


        }
    }
}
