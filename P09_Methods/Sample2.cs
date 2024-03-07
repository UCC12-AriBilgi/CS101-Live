using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Methods
{
    internal class Sample2
    {
        public static void Main(string[] args)
        {
            #region Metotlarda aşırı yükleme (method overloading)

            Console.WriteLine($"2li toplama sonucu = {ToplamaIslemi(34,56)}\n\n");

            Console.WriteLine($"3lü toplama sonucu = {ToplamaIslemi(34,56,33)}\n\n");

            Console.WriteLine($"4lü toplama sonucu = {ToplamaIslemi(34,56,12,30)}\n\n");


            #endregion


            Console.ReadKey();


        }

        #region Methods

        private static int ToplamaIslemi(int psayi1,int psayi2)
        { // ikili toplama için
            return psayi1 + psayi2;
        } 

        private static int ToplamaIslemi(int psayi1,int psayi2,int psayi3)
        {// üçlü toplama için
            return psayi1 + psayi2 + psayi3;
        }

        private static int ToplamaIslemi(int psayi1, int psayi2, int psayi3,int psayi4)
        {// dörtlü toplama için
            return psayi1 + psayi2 + psayi3+psayi4;
        }



        #endregion
    }
}
