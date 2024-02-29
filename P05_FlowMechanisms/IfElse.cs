using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_FlowMechanisms
{
    internal class IfElse
    {
        public static void Main(string[] args)
        {
            // if-else...belli bir koşul sağlandığında bu koşula uygun olan komutlar çalıştırılır. koşul sağlanmıyorsa diğer komutlar çalıştırılır

            // Syntax:
            //
            // if (koşulumuz)
            //  {
            //      doğru ise çalışacak kod bloğu
            //  }
            //  else
            //  {
            //      yanlışsa çalışacak jkod bloğu
            //  }

            #region 1.Standart kullanım

            //int sayi1 = 15;
            //int sayi2 = 5;

            //if (sayi1 < sayi2)
            //{
            //    Console.WriteLine("Evet...sayi1  sayı 2 den küçüktür...");
            //}
            //else
            //{
            //    Console.WriteLine("Hayır...sayi1  sayı2 den büyüktür...");
            //}

            #endregion

            #region 2. diğer bir kullanım şekli
            // her zaman else ifadesinin kullanılması şart değildir.

            //int sayi11 = 12;
            //int sayi21 = 4;

            //if (sayi11 != sayi21)
            //{
            //    Console.WriteLine("Haklısın ...eşit değil");
            //}
            //....


            #endregion

            #region şöyle bir kullanım

            //Console.WriteLine( "Lütfen cinsiyet bilginizi giriniz (e/k): ");

            //// ekrandan/klavyeden bilgi okuma yapılacak
            ////char cins=Convert.ToChar(Console.ReadLine()); // ekrandan okuduğunu char turune cevir 

            ////if ( cins == 'e') // Kontrol 
            ////{
            ////    Console.WriteLine("Cinsiyet : Erkek..");
            ////}
            ////else if( cins == 'k')
            ////{
            ////    Console.WriteLine("Cinsiyet : Kadın..");
            ////}
            ////else 
            ////{ 
            ////    Console.WriteLine("Lütfen doğru bilgi giriniz..."); 
            ////}


            #endregion

            #region Kullanıcı adı/şifre giriş kontrolu
            // ekrandan iki adet bilgi alıcam. kullanıcı adı ve şifre. 2 si birden kendi tanımladığım değerlerle aynıysa "Sisteme hoşgeldiniz" diye mesaj çıksın ekrana. değilse bana hangi bilginin uygun olmadığını söylesin...
            //string benimkad = "admin"; // benim tanımladığım kullanıcı adı
            //string benimsifre = "1234"; // şifre

            //string ekad; // ekrandan alınan kull adı
            //string esifre; // ekrandan alınan sifre

            //Console.WriteLine("Kullanıcı Adı :");
            //ekad =Console.ReadLine(); // ekrandan okuyup değişgene yerlestirdi

            //Console.WriteLine("Kullanıcı Şifre :");
            //esifre = Console.ReadLine(); // ekrandan okuyup değişgene yerlestirdi

            //if (ekad == benimkad)
            //{
            //    if (esifre == benimsifre)
            //    {
            //        Console.WriteLine("Sisteme hoşgeldiniz..İyi çalışmalar...");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Girilen bilgi doğru değil...Lütfen kontrol ediniz...");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Girilen bilgi doğru değil...Lütfen kontrol ediniz...");
            //}

            #endregion

            #region 2 sayıdan büyük olanı bulma, ekrandan girilecek olan sayılar var...
            // readline string okuduğu için bunu sayıya cevirmek için .ToInt32() kullanabilirsiniz

            //int sayi1; // ekrandan alacağım bilgiyiyi tutacak
            //int sayi2; // "

            //Console.WriteLine("Lütfen 1.sayınızı giriniz : ");
            //sayi1=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.sayınızı giriniz : ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Evet sayi1 sayi2 den büyüktür....");
            //}
            //else if (sayi2 > sayi1) 
            //{
            //    Console.WriteLine("Hayır sayi1 sayi2 den küçüktür....");

            //}
            //else
            //{
            //    Console.WriteLine("İki sayı da birbirine eşittir...");
            //}



            #endregion

            #region Daily Workout !
            // 3 sayıdan büyük olanı bulma, ekrandan girilecek olan sayılar var...
            int sayi1, sayi2, sayi3;

            Console.WriteLine("Lütfen 1.sayınızı giriniz : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2.sayınızı giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 3.sayınızı giriniz : ");
            sayi3 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                if (sayi1 > sayi3)
                {
                    Console.WriteLine($"En büyük sayi1 dir...Değeri {sayi1}\n\n");
                }
            }

            if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                Console.WriteLine($"En büyük sayi2 dir...Değeri {sayi2}\n\n");
            }

            if ((sayi3 > sayi1) && (sayi3 > sayi2))
            {
                Console.WriteLine($"En büyük sayı3 tür...Değeri {sayi3}\n\n");
            }

            // Daily workout2 
            // // 3 sayıdan küçük olanı bulma, ekrandan girilecek olan sayılar var...

            if (sayi1 < sayi2 && sayi1 < sayi3)
            {
                Console.WriteLine($"En küçük sayi1 dir...Değeri {sayi1}\n\n");
            }

            if (sayi2 < sayi1 && sayi2 < sayi3)
            {
                Console.WriteLine($"En küçük sayi2 dir...Değeri {sayi2}\n\n");
            }

            if ((sayi3 < sayi1) && (sayi3 < sayi2))
            {
                Console.WriteLine($"En küçük sayı3 tür...Değeri {sayi3}\n\n");
            }

            #endregion




        }
    }
}
