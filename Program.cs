using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş qiymət dəyəri 64-dən böyük olarasa console-da "məzun oldunuz", əks halda "məzun olmadınız" yazdırsan proqram.
            Console.WriteLine("ededi daxil edin");
            string numStr = Console.ReadLine();
            int num = Convert.ToInt32(numStr);



            if (num >= 64 && num <= 100)
            {
                Console.WriteLine("mezun oldunuz");
            }

            else if (num > 100 && num < 0)
            {
                Console.WriteLine("mezun ola bilmediniz");
            }

            //Verilmiş ədədlər siyahısındaki 21-ə bölenən ədədlərin ədədi ortasını tapan proqram
            int[] numbers = { 10, 15, 20, 25, 30, 35, 40 };
            double sum = 0;
            double count = 0;
            for (int i = 0; i < numbers.Length; i++)
            if (numbers[i] % 21 == 0)
            {
                count++;
                sum += numbers[1];

            }
            if (count > 0) ;
            {
                sum / count
                 
                    
            }
            Console.WriteLine(sum);

        }
        
    }
}
