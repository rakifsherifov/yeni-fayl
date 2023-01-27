using System;
using System.Reflection.Emit;
using System.Threading;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("1-ci ededi daxil edin:");
            string num1er = Console.ReadLine();
            int num1 = Convert.ToInt32(num1er);

            Console.WriteLine("2-ci ededi daxil edin:");
            string num2er = Console.ReadLine();
            int num2 = Convert.ToInt32(num2er);

            Console.WriteLine("3-ci ededi daxil edin:");
            string num3er = Console.ReadLine();
            int num3 = Convert.ToInt32(num3er);

            
            if (num1 > num2 && num1 > num3 ) 
            {
                Console.WriteLine("birinci daxil edilmis eded boyudur");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("ikinci daxil edilmis eded boyudur");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine(" ucuncu daxil edilmis eded boyudur");
            }



            //muellim axirinci iki tapsirigi yaza bilmedim deye basqa bir program yazacam
            //sual- ilin aylarinin reqemine esasen hansi fesil oldugunu tapan program;

            Console.WriteLine("ilin ayinin sira reqemini daxil edin:");
            string monthStr = Console.ReadLine();
            int month = Convert.ToInt32(monthStr);
            switch (month)
            {
                case 1:
                    Console.WriteLine("qis feslidir");
                    break;
                case 2:
                    Console.WriteLine("qis feslidir");
                    break;
                case 3:
                    Console.WriteLine("yazfeslidir");
                    break;
                case 4:
                    Console.WriteLine("yaz feslidir");
                    break;
                case 5:
                    Console.WriteLine("yaz feslidir");
                    break;
                case 6:
                    Console.WriteLine("yay feslidir");
                    break;
                case 7:
                    Console.WriteLine("yay feslidir");
                    break;
                case 8:
                    Console.WriteLine("yay feslidir");
                    break;
                case 9:
                    Console.WriteLine("payiz feslidir");
                    break;
                case 10:
                    Console.WriteLine("payiz feslidir");
                    break;
                case 11:
                    Console.WriteLine("payiz feslidir");
                    break;
                case 12:
                    Console.WriteLine("qis feslidir");
                    break;
                default:
                    Console.WriteLine("daxil etdiyiniz eded yanlisdir!");
                    break;














            }
    }
}
