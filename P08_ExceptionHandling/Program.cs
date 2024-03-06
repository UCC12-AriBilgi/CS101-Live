namespace P08_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hata oluşturabilecek bir durum
            //int sayi1 = 100;
            //int sayi2 = 0;

            //int sonuc = sayi1 / sayi2;

            //Console.WriteLine($"Bölme işleminin sonucu : {sonuc}");


            #endregion

            #region Hata Avcısı
            //int sayi1 = 100;
            //int sayi2 = 0;

            ////avcı
            //try
            //{
            //    int sonuc = sayi1 / sayi2;

            //    Console.WriteLine($"Bölme işleminin sonucu : {sonuc}");
            //}
            //catch (Exception)
            //{

            //    //Console.WriteLine("Valla arkadas..bir yerlerde terslik var..bakcaz..");


            //    if (sayi1 !=0 && sayi2==0)
            //    {
            //        sayi2 = 1;
            //        int sonuc = sayi1 / sayi2;
            //        Console.WriteLine($"Durum düzeltildi..{sonuc}");
            //    }
            //}

            #endregion

            #region Biraz daha detaylı örnek
            double bolunecek, bolen;

            try
            {
                Console.Write("Bölünecek değeri giriniz : ");
                bolunecek=Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Bölen değeri giriniz : ");
                bolen=Convert.ToInt32(Console.ReadLine());

                double sonuc = bolunecek / bolen;

                Console.WriteLine($"{bolunecek} değerinin {bolen} değerine bölümünün sonucu {sonuc}..\n\n");

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Hata - Sıfıra bölüm işlemi gerçekleştirilemez..Hata mesajı : {e.Message}\n");

            }
            catch (FormatException e)
            {
                Console.WriteLine($"Hata - Sadece Int32 türünde veri girişi yapabilirsiniz..Hata mesajı : {e.Message}\n");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Hata - Değişgen sınırlarını aştınız..Hata mesajı : {e.Message} \n");
            }
            catch (Exception e) // Geri kalan tüm hata durumları
            {
                Console.WriteLine($"Hata - Beklenmedik hata..Hata mesajı : {e.Message} \n");
            }
            finally 
            {
                Console.WriteLine("Finally bloğu çalışıyor.\n");
            }






            #endregion


            Console.ReadKey();
        }
    }
}
