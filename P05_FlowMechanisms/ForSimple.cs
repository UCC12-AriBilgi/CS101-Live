using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_FlowMechanisms
{
    internal class ForSimple
    {
        public static void Main(string[] args)
        {
            // for(baslangıc;kosul;son)
            // {
            //      yapılacak işler
            // }

            #region Kullanıcıdan alınan adet kadar ekrana "Merhaba Dünya" yazdırınız..Aralarında bir satır da boşluk olsun

            //int adet=0;

            //Console.WriteLine("Lütfen mesaj yazdırılacak adet bilgisini giriniz :");
            //adet = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= adet; i++) // kosul doğru old.surece { } arasındaki işlemi yap
            //{

            //    Console.WriteLine(i.ToString() + " - Merhaba dünya..Nası gidiyor...Dark evrenine hoşgeldiniz...\n\n");
            //}

            #endregion

            #region ekrandan alınacak 2 sayı arasındaki değerleri ekrana yazınız..
            //int sayi1, sayi2;

            //Console.WriteLine("Lütfen 1.sayı : ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.sayı : ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());


            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    Console.WriteLine("Sayı - " + i.ToString() + "\n\n");
            //}


            #endregion

            #region girilen iki sayı arasının toplamını veren programı yazınız...Sonuçta toplam gözüksün.
            //int sayi1, sayi2,toplam;

            //Console.WriteLine("Lütfen 1.sayı : ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.sayı : ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());


            //toplam = 0;

            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    toplam = toplam + i;
            //}

            //Console.WriteLine("Toplam - " + toplam.ToString() + "\n");



            #endregion


            #region Kullanıcının girdiği 2 sayının çarpma işlemini toplama kullanarak bulunuz ve yazınız
            //int sayi1, sayi2, sonuc;

            //Console.WriteLine("Lütfen 1.sayı : ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.sayı : ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());


            //sonuc = 0;

            //for (int i = 0; i < sayi1; i++)
            //{
            //    sonuc = sonuc + sayi2;
            //}

            //Console.WriteLine("Çarpım sonucu - " + sonuc.ToString() + "\n");



            #endregion

            #region Kullanıcıdan 6 adet sayı alınacak.(-,+) Çıkışta istenen durum..
            // negatiflerin toplamını ayrı
            // pozitiflerin toplamını ayrı göstersin
            // Örnek : Negatif sayıların toplamı = -24
            //          Pozitif sayıların toplanmı = 55 

            int sayi; // Ekrandan alınacak değer

            int ptoplam=0; // Pozitiflerin toplamını tutacak
            int ntoplam=0; // Negatiflerin     "

            for (int sayac = 1; sayac <= 6; sayac++)
            {
                Console.WriteLine("Lütfen " + sayac.ToString() + ".sayınızı giriniz : ");
                sayi =int.Parse(Console.ReadLine());

                if (sayi > 0)
                {
                    ptoplam += sayi; // sayı pozitifse ptoplam a ekliyorum
                }
                else
                {
                    ntoplam += sayi; // sayı negatifse ntoplam a ekliyorum
                }

            }

            Console.WriteLine($"Pozitif sayıların toplamı = {ptoplam} \n\n");
            Console.WriteLine($"Negatif sayıların toplamı = {ntoplam} \n\n");



            #endregion


            Console.ReadKey();
        }

    }
}
