using System;

namespace _3reqemli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir 2 reqemli eded daxil edin");

            Console.WriteLine("------------------");

            string num = Console.ReadLine();

            int a = int.Parse(num);

            if (a>=10 && a<100)

            {

                Console.WriteLine("Netice");

                Console.WriteLine("------------");

                Console.WriteLine($"{a}{a}");

            }
            else
            {
                Console.WriteLine("---------------");

                Console.WriteLine("Nezere alinmayib");
            }
        }
    }
}
