using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_FlowMechanisms
{
    internal class DoWhile_Intermediate
    {
        public static void Main(string[] args)
        {
            // Çok basit sekilde 4 işlem yapan mini bir hesap makinesi
            // Burada bir menu sistemi olsun
            // nested do while...

            char choice; // hangi secenek (çıkış için)
            int menuOption; // menuden hangi işlemi seçtim + - * /
            int number1, number2;
            int sonuc = 0;

            // Menu tasarlanıyor

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Addition\n2 - Substraction\n3 - Multiply\n4- Divide");

                menuOption=Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Sayı1 :");
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Sayı2 :");
                number2 = Convert.ToInt32(Console.ReadLine());

                switch (menuOption)
                {
                    case 1:
                        sonuc= number1+number2;
                        break;
                    case 2:
                        sonuc = number1 - number2;
                        break;
                    case 3:
                        sonuc = number1 * number2;
                       break;
                    case 4:
                        sonuc = number1 / number2;
                        break;
                    default:
                        Console.WriteLine("Lütfen doğru seçim giriniz...");
                        break;
                }

                Console.WriteLine($"Sonuç : {sonuc}");
                Console.WriteLine("\n\nTekrar yapmak için T,çıkış yapmak için herhangi bir tusa basınız...");

                choice=Convert.ToChar((Console.ReadLine()));


            } while (Char.ToUpper(choice) == 'T');



            //Console.ReadKey();
        }
    }
}
