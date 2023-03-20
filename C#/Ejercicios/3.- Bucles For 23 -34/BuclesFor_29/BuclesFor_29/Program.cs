using System;

namespace BuclesFor_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, min, max;

            Console.WriteLine("Dime un número");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime otro número");
            b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                min = a;
                max = b;
            }

            else
            {
                min = b;
                max = a;
            }

            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
