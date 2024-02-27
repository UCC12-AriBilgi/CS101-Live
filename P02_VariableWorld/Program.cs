using System.Security.Cryptography.X509Certificates;

namespace P02_VariableWorld
{
    internal class Program
    {
        //int a;
        // Burası programa ilk giriş noktası
        static void Main(string[] args)
        {
            #region İlk denemeler 
            //string name = ""; // ilk değer verildi. hem de değişgen tanımlandı.
            //string Name = ""; // yukardakinden tamamen farklı
            //string nameDesc;
            //string NameDesc;

            //nameDesc = "Benim adım ";
            //NameDesc = "Kızımın adı ";

            //name = "Ümit Karaçivi";
            //Name = "Doğa Bengi Karaçivi";

            //Console.WriteLine(nameDesc + name + "\n\n");
            //Console.WriteLine(NameDesc + Name + "\n\n");

            #endregion

            #region Sabitler

            //const string prgadi = "P02_Variable World";

            //Console.WriteLine("Programımızın adı : " + prgadi);

            #endregion

            #region Değişgenlere devam

            //int a = 5; // ilk değer atamalı integer türünden

            //int b,c,d,e; // Tek satırda aynı türden çoklu tanımlama

            //int f = 10, g, m = 70; // çoklu tanımlama

            //var a1 = 6; //Bilinçsiz değişgen tanımlaması
            //var metin = "Metin bilgi";

            //char deg1 = 'A';
            //string deg2 = "Deneme";

            //string deg3 = deg1 + deg2 + "bilgi" + 'm'; // string birleştirme
            ////Console.WriteLine(deg3);

            //byte sayi1 = 100;
            //byte sayi2 = 200;

            //int toplam= sayi1 + sayi2;

            //Console.WriteLine("Toplam : " + toplam);


            #endregion

            #region Değişgen tanımlarken yapılabilen hatalar

            // Değişgen tanımlamasını ve/veya değer vermeyi yanlış yerde yapmak

            // tüm değişgenlerin tanımlamaları Main bloğu içinde yapılmalıdır/olmalıdır...

            //Console.WriteLine(a);

            // Bazı değişgen türlerinde değişgenlere değer verirken eklenmesi gereken bazı karakterleri eklememek.

            //float fl = 12.5;
            //float fl = 12.5f;

            // Ondalık sayıların ondalık kısmını yazarken nokta(.) yerine (,) koymak
            //float fl = 12,5f;

            // metinsel(string) türden değişgenlerde matematiksel işlem yapmaya çalışmak

            //string a5 = "12345";
            //string b5 = "54321";

            //string ab= a5 + b5;

            //Console.WriteLine(ab+ "\n\n");


            //int toplam = Convert.ToInt32(a5) + Convert.ToInt32(b5); // Convert...çevrim

            //Console.WriteLine("Toplam : " + toplam.ToString());

            // Bir değişgeni birden fazla tanımlamak
            //string a;
            //string a = "deneme";

            // Bir değişgene yanlış atama yapmak
            //string a = deneme;
            //int b = "ahmet";

            #endregion






            Console.ReadKey();

        }


    }
}
