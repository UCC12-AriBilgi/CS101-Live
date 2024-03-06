using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Methods
{
    internal class Sample1
    {
        public static void Main(string[] args)
        {
            // Hack01
            // Dikdörtgen alanını hesaplayan bir metodun 4 farklı seklinin incelenmesi

            #region 1. Geriye değer döndürmeyen ve parametre almayan metot

            //Hesapla();

            #endregion

            #region 2. Geriye değer döndürmeyen ama parametre alan metot
            // Kullanıcı girişi gibi işlemler burada...
            // hesap kitap metotda olacak ...dolayısıla buradan almış olduğum bilgileri parametre olarak metoda göndereceğim
            //Console.WriteLine("Lütfen kısa kenarı giriniz :");
            //int kk = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen uzun kenarı giriniz :");
            //int uk = Convert.ToInt32(Console.ReadLine());

            //Hesapla(kk, uk);

            #endregion

            #region 3. Geriye değer döndüren parametre almayan metot

            //int sonuc = HesaplaPrmsiz();

            //Console.WriteLine($"\nDikdörtgenin alanı = {sonuc}");

            #endregion

            #region 4. Geriye değer döndüren ve parametre alan metot

            Console.WriteLine("Lütfen kısa kenarı giriniz :");
            int kk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen uzun kenarı giriniz :");
            int uk = Convert.ToInt32(Console.ReadLine());

            //int sonuc1 = HesaplaPrmli(kk, uk);

            Console.WriteLine($"\nDikdörtgenin alanı = {HesaplaPrmli(kk, uk)}");

            #endregion



            Console.ReadKey();
        }

        #region Methodlar
        // region 1
        private static void Hesapla()
        {
            Console.WriteLine("Lütfen kısa kenarı giriniz :");
            int kk=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen uzun kenarı giriniz :");
            int uk=Convert.ToInt32(Console.ReadLine());

            int alan = kk * uk;

            Console.WriteLine($"\nDikdörtgenin alanı = {alan}");


        }

        // region 2
        private static void Hesapla(int pkisakenar,int puzunkenar)
        {
            int alan=pkisakenar * puzunkenar;
            
            Console.WriteLine($"\nDikdörtgenin alanı = {alan}");
        }

        // region 3
        private static int HesaplaPrmsiz()
        {
            // geriye değer döndüren metotlarda mutlaka return keyword ü olmalıdır
            Console.WriteLine("Lütfen kısa kenarı giriniz :");
            int kk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen uzun kenarı giriniz :");
            int uk = Convert.ToInt32(Console.ReadLine());

            int alan = kk * uk;

            return alan;
        }

        private static int HesaplaPrmli(int kisak,int uzunk)
        {
            return kisak * uzunk;
        }

        #endregion
    }
}
