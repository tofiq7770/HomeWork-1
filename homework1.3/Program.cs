using System;

namespace homework1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci ededi daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());


            if (a+b>=10 && a+b<100)
            {
                Console.WriteLine("cem ikireqemli ededdir");
            }
            else if (a+b>=100 && a+b <1000)
            {
                Console.WriteLine("cem uc reqemli ededdir");
            }
            else
            {
                Console.WriteLine("nezere alinmayib");
            }
        }
    }
}
