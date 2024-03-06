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

            //Console.WriteLine("Lütfen kısa kenarı giriniz :");
            //int kk = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen uzun kenarı giriniz :");
            //int uk = Convert.ToInt32(Console.ReadLine());

            ////int sonuc1 = HesaplaPrmli(kk, uk);

            //Console.WriteLine($"\nDikdörtgenin alanı = {HesaplaPrmli(kk, uk)}");

            #endregion

            #region Hack02
            //Uygun metot yapısına göre en uygun göreceğiniz yapıya göre
            // ekrandan alınacak 2 sayı için 4(+,-,*,/) işlemi gerçekleştirecek pp
            // Gerekiyorsa birden fazla metot da yazabilirsiniz.
            // Hint : işlem tipi diye bir değişgende tutarak hangi işlemin istendiğini ve ona göre çalışmasını sağlayabilirsiniz..
            Console.WriteLine("Lütfen 1.sayıyı giriniz :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2.sayıyı giriniz :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nİşlem türü (+,-,*,/) giriniz :");
            string secenek = Console.ReadLine();



            #endregion






            Console.ReadKey();
        }

        #region Methodlar
        // region 1 geri yok prmsiz
        private static void Hesapla()
        {
            Console.WriteLine("Lütfen kısa kenarı giriniz :");
            int kk=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen uzun kenarı giriniz :");
            int uk=Convert.ToInt32(Console.ReadLine());

            int alan = kk * uk;

            Console.WriteLine($"\nDikdörtgenin alanı = {alan}");


        }

        // region 2 geri yok prmli
        private static void Hesapla(int pkisakenar,int puzunkenar)
        {
            int alan=pkisakenar * puzunkenar;
            
            Console.WriteLine($"\nDikdörtgenin alanı = {alan}");
        }

        // region 3 geri var prmsiz
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

        // region 4 geri var parametre var
        private static int HesaplaPrmli(int kisak, int uzunk)
        {
            return kisak * uzunk;
        }

        // region Hack02
        private static int DortIslem(int psayi1,int psayi2,string psecek) 
        {
            // bütün iş burada dönecek

            return 0;
        }
        #endregion
    }
}
