using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Methods
{
    internal class Sample3
    {
        public static void Main(string[] args)
        {
            // Nightly Workout
            // Erkeklerin 25 yıl, kadınların 20 yıl çalıştıktan sonra emekli olacağı varsayılan bir ortamda, ekrandan girilen cinsiyet ve sigorta prim gün sayısına göre kişinin emekliliğine ne kadar süresi kaldığını hesaplayan pp.

            // Bazı kabuller
            // 1 yıl 360 gün
            // 1 ay 30 gün kabul edilsin
            // Örnek : kalan 1943 gün : 5 yıl 4 ay 23 gün
            // Kadınlar için 7200 gün
            // Erkekler için 9000 gün kabulu

            // Çıkışımız
            // Erkek,6643 gün
            // Emekliliğinize 6 yıl 6 ay 17 gün kaldı....desin

            int Year = 360;
            int Month = 30;
            int dayCount; // sgk gün sayısı
            string gender; // cinsiyet bilgisi

            Console.WriteLine("Lütfen cinsiyet bilgisini giriniz (E/K) ");
            gender = Console.ReadLine().ToUpper();

            Console.WriteLine("Lütfen prim gün sayınızı giriniz :");
            dayCount = Convert.ToInt32(Console.ReadLine());

            dayCount = retirementCalc(gender, dayCount); // sadece gün farkı hesaplamak için

            int year = dayCount / Year;
            dayCount %= Year;

            int month= dayCount / Month;
            dayCount %= Month;

            int day = dayCount;

            Console.WriteLine($"\n\nEmekliliğinize {year} yıl, {month} ay, {day} gün kalmıştır..Hayırlı olsun... ");




            Console.ReadKey();
        }


        #region Methods
        private static int retirementCalc(string pGender,int pDay)
        {
            int dayForWoman = 7200;
            int dayForMan = 9000;
            int diffDay=0; // fark günü

            switch (pGender)
            {
                case "E":
                    diffDay = dayForMan - pDay;
                    break;

                case "K":
                    diffDay= dayForWoman - pDay;
                    break;

                default:
                    break;
            }

            return diffDay;
        }



        #endregion
    }
}
