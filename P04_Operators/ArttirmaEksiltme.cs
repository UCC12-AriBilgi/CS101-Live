using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Operators
{
    internal class ArttirmaEksiltme
    {
        public static void Main(string[] args)
        {
            Console.Clear();// Konsol ekranını temizler


            Console.WriteLine("*************************");
            Console.WriteLine("*                       *");
            Console.WriteLine("*   ART.EKS. OP.        *");
            Console.WriteLine("*                       *");
            Console.WriteLine("*************************");

            #region 2. Bir arttırma ve eksiltme operatörleri
            // C# da en çok kullanılan operatörlerden biridir.Önüne veya sonuna geldiği değişgeni 1 arttırır veya 1 eksiltir. Sabitlere uygulanmazlar. son ek ve ön ek olarak 2 farklı kullanın sekli var.

            int fonceki = 5;

            int fsonraki = ++fonceki;
            // Prefix/Önek örneği. hem fonceki değerini 1 artırdı.bu değeri tuttu. Sonra bu değeri fsonraki değişgenine atadı.

            Console.WriteLine("Sonuc 2 Önek: Önceki değer " + fonceki + ", sonraki değer " + fsonraki + "\n\n");

            int gonceki = 10;

            int gsonraki = gonceki++;
            //Sonek örneği önce gonceki degerini gsonraki ne aktarır.Ondan sonra değerini bir artırdı.

            Console.WriteLine("Sonuc 2.1 Sonek : Önceki değer " + gonceki + ", sonraki değer " + gsonraki + "\n\n");

            // Biraz karışık gibi

            int h = 5;

            int i = h++;

            int j = i--;

            int k = 10;

            int l = --k;

            // Parametrik gösterim
            Console.WriteLine("Sonuc 2.2 : h={0}\ti={1}\tj={2}\tk={3}\tl={4}",h,i,j,k,l);


            

            #endregion


        }
    }
}
