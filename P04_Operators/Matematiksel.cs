using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Operators
{
    internal class Matematiksel
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*************************");
            Console.WriteLine("*                       *");
            Console.WriteLine("*   MATEMATİKSEL OP.    *");
            Console.WriteLine("*                       *");
            Console.WriteLine("*************************");

            #region 1. % operatörü (mod alma)
            // bir sayının 2'ye bölümü işleminde kalan değerini verir.

            //int a = 5 % 2;
            //int b = 6 % 2;

            //Console.WriteLine("Sonuc 1.a : \t" + a.ToString() + "\n\n");
            //Console.WriteLine("Sonuc 1.b : \t" + b.ToString() + "\n\n");


            #endregion

            #region 1.1 Değişik bir durum
            // Eğer işlem yapılan her iki operand farklı türdelerse sonuç daha üst kapasiteli türde olur.
            //float c = 5 / 2f;

            //Console.WriteLine("Sonuc 1.1 : " + c + "\n\n");

            #endregion

            #region 1.2 Ancak durumu...
            // İşlemler soldan sağa doğru yapılıyor
            // 2 5 int sayılar olduğu için daha işleme başlarken 0 değeri oluşur ..sonuc 0
            //float d = 2 / 5 / 2f;

            #endregion

            #region 1.3 Diğer durum

            float e = 2f / 5f / 2;
            Console.WriteLine("Sonuc 1.3 : " + e + "\n\n");

            #endregion

            #region 1.4

            float f = 3f / 5 / 6 / 8 / 2f / 9;

            Console.WriteLine("Sonuc 1.4 : " + f);


            #endregion



        }
    }
}
