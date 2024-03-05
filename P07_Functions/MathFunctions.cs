using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Functions
{
    internal class MathFunctions
    {
        public static void Main(string[] args)
        {
            #region Abs metodu - Absolute..Mutlak değer
            // verilen bir sayının matematiksel olarak mutlak değerini almak kullanılır. Abs metodu parametre olarak farklı veri turlerinde değer alabilir. Sonuc aldığı türden verilir.yani int ise int, double ise double gibi...
            //int sayi1 = -5;
            //double sayi2 = -345.678;

            //int sonuc1= Math.Abs(sayi1);
            //Console.WriteLine($"Abs sonuc(int) {sonuc1}\n\n");

            //double sonuc2 = Math.Abs(sayi2); ;
            //Console.WriteLine($"Abs sonuc(double) {sonuc2}\n\n");

            //// float,long,decimal,short...

            //// Hack01
            //// Klavyeden alınan bir tam sayının mutlak değerini bulan ve yazdıran pp

            //Console.WriteLine("Lütfen sayınızı giriniz...");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Abs sonuc(int) {Math.Abs(sayi3)}\n\n");


            #endregion

            #region Min-Max
            //int sayi4 = 55;
            //int sayi5 = 15;

            //Console.WriteLine($"Küçük olan : {Math.Min(sayi5, sayi4)}");
            //Console.WriteLine($"Büyük olan : {Math.Max(sayi5, sayi4)}");

            // diğer veri için de aynı tür kullanım gecerli

            #endregion

            #region Pow Power
            int sayi6 = 2;
            int sayi7 = 3;

            Console.WriteLine($"2 ün küpü : {Math.Pow(sayi6, sayi7)}");
            Console.WriteLine($"3 ün karesi : {Math.Pow(sayi7, sayi6)}");


            #endregion

            #region Round - Yuvarlama
            // parametre olarak verilen ondalıklı sayıyı en yakın tamsayıya yuvarlama işlemi yapıyor.

            Console.WriteLine($"Yuvarlama 1 - {Math.Round(0.5)}\n\n");
            Console.WriteLine($"Yuvarlama 2 - {Math.Round(3.01)}\n\n");
            Console.WriteLine($"Yuvarlama 3 - {Math.Round(3.49)}\n\n");
            Console.WriteLine($"Yuvarlama 4 - {Math.Round(3.51)}\n\n");
            Console.WriteLine($"Yuvarlama 5 - {Math.Round(3.50)}\n\n");




            #endregion

            #region Sqrt - SquareRoot - Karekök

            Console.WriteLine($"Karekök 1 - {Math.Sqrt(4)}\n\n");
            Console.WriteLine($"Karekök 2 - {Math.Sqrt(3.01)}\n\n");
            Console.WriteLine($"Karekök 3 - {Math.Sqrt(3.49)}\n\n");
            Console.WriteLine($"Karekök 4 - {Math.Sqrt(3.51)}\n\n");
            Console.WriteLine($"Karekök 5 - {Math.Sqrt(312.5057)}\n\n");

            #endregion

            #region Ceiling
            // parametre olarak verilen ondalıklı sayısı yukarıya veya eğer bir tamsayı verilmişse tamsayının aynısına yuvarlama yapar

            Console.WriteLine($"Tavana yuvarlama 1 - {Math.Ceiling(4.0)}\n\n");
            Console.WriteLine($"Tavana yuvarlama 2 - {Math.Ceiling(3.01)}\n\n");
            Console.WriteLine($"Tavana yuvarlama 3 - {Math.Ceiling(3.49)}\n\n");
            Console.WriteLine($"Tavana yuvarlama 4 - {Math.Ceiling(3.51)}\n\n");
            Console.WriteLine($"Tavana yuvarlama 5 - {Math.Ceiling(312.5057)}\n\n");


            #endregion

            Console.ReadKey();
        }
    }
}
