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
            int sayi1 = 100;
            int sayi2 = 0;

            //avcı
            try
            {
                int sonuc = sayi1 / sayi2;

                Console.WriteLine($"Bölme işleminin sonucu : {sonuc}");
            }
            catch (Exception)
            {

                //Console.WriteLine("Valla arkadas..bir yerlerde terslik var..bakcaz..");


                if (sayi1 !=0 && sayi2==0)
                {
                    sayi2 = 1;
                    int sonuc = sayi1 / sayi2;
                    Console.WriteLine($"Durum düzeltildi..{sonuc}");
                }
            }



            #endregion




            Console.ReadKey();
        }
    }
}
