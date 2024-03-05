using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Functions
{
    internal class StringFunctions
    {
        public static void Main(string[] args)
        {
            #region Length
            string metin = "\tArı Bilgi Yazılım Eğitimi";

            // boşluklar da dahil....
            Console.WriteLine($"Metin : {metin}");
            Console.WriteLine($"Metnin uzunluğu : {metin.Length}");


            #endregion

            #region ToLower/ToUpper

            Console.WriteLine($"Metnin küçük hali : {metin.ToLower()}");
            Console.WriteLine($"Metnin büyük hali : {metin.ToUpper()}");

            #endregion


            #region Concat - Concatenate
            string metin1=Console.ReadLine();
            string metin2=Console.ReadLine();

            string sonuc = String.Concat(metin1," ","\t", metin2);   
            Console.WriteLine($"Concat sonrası : {sonuc}");


            #endregion






            Console.ReadKey();

        }
    }
}
