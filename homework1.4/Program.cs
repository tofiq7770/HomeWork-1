using System;

namespace homework1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>=0 && a<10 )
            {
                Console.WriteLine("1-reqemli");
            }
             if (a >= 10 && a < 100)
            {
                Console.WriteLine("2-reqemli");
            }
             if (a >= 100 && a < 1000)
            {
                Console.WriteLine("3-reqemli");
            }
             if (a >= 1000 && a < 10000)
            {
                Console.WriteLine("4-reqemli");
            }
             if (a >= 10000 && a < 100000)
            {
                Console.WriteLine("5-reqemli");
            }
            else
            {
                Console.WriteLine("Sherte uyghun deyildir");
            }

        }
    }
}
