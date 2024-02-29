using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_FlowMechanisms
{
    internal class SwitchCase
    {
        public static void Main(string[] args)
        {
            // switch ( koşul )
            //{
            //  case deger1 :
            //      ......
            //      break;
            //  case deger2 :
            //      ......
            //      break;
            //  case deger3 :
            //      ......
            //      break;
            // ......
            //  case default :
            //      ......
            //      break;

            #region switch_case 1
            //int deger;

            //// 1..10 arası bir değer girilecek
            //Console.WriteLine("Lütfen 1-10 arasında değeri giriniz...");
            //deger = Convert.ToInt32(Console.ReadLine());

            //switch (deger) // Neye göre biryerlere atlayacağım
            //{
            //    case 1:
            //        Console.WriteLine($"Girdiğiniz değer {deger}");
            //        break;
            //    case 2:
            //        Console.WriteLine($"Girdiğiniz değer {deger}");
            //        break;
            //    case 3:
            //        Console.WriteLine($"Girdiğiniz değer {deger}");
            //        break;
            //    case 4:
            //        Console.WriteLine($"Girdiğiniz değer {deger}");
            //        break;
            //    case 5:
            //        Console.WriteLine($"Girdiğiniz değer {deger}");
            //        break;
            //    case 6:
            //        Console.WriteLine($"Girdiğiniz değer {deger}");
            //        break;
            //    case 7:
            //        Console.WriteLine($"Girdiğiniz değer {deger}");
            //        break;
            //    case 8:
            //        Console.WriteLine($"Girdiğiniz değer {deger}");
            //        break;
            //    case 9:
            //        Console.WriteLine($"Girdiğiniz değer {deger}");
            //        break;
            //    case 10:
            //        Console.WriteLine($"Girdiğiniz değer {deger}");
            //        break;
            //    default:
            //        Console.WriteLine("İstenen aralıkta girin lütfen...");
            //        break;
            //}

            #endregion

            #region switch_case 2

            //int deger = Convert.ToInt32(Console.ReadLine());

            //switch (deger)
            //{
            //    case 1:
            //        Console.WriteLine("Merhaba..");
            //        break;
            //    case 2:
            //        string bilgi=Console.ReadLine();

            //        Console.WriteLine($"Girdiğiniz bilgi : {bilgi} dir..");
            //        break;

            //    default:
            //        break;
            //}

            #endregion

            #region switch_case 3
            // eğer bir case içersinde gerektiğinde baska bir case durumuna atlayabiliriz

            //int deger = 5;

            //switch (deger)
            //{
            //    case 4:
            //        string k1=Console.ReadLine();

            //        Console.WriteLine(k1);

            //        break;
            //    case 5:
            //        Console.WriteLine("Şimdi case 4 e gideceksiniz...");
            //        goto case 4;


            //    default:
            //        break;
            //}


            #endregion


            #region switch_case 4
            // farklı değerlerin aynı case bloğunda kullanılması gerekebilir

            int deger = Convert.ToInt32(Console.ReadLine());

            switch (deger)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine($"Girdiğiniz değer {deger} dir...");
                    break;
                default:

                    break;
            }


            #endregion

            Console.ReadKey();
        }
    }
}
