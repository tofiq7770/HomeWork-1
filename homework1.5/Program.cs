using System;

namespace homework1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci Ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikinci Ededi daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a%b==0)
            {
                Console.WriteLine("Tam Bolunur");
            }
            else
            {
                Console.WriteLine("Tam Bolunmur");
            }
        }
    }
}
