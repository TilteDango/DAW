using System;

namespace BuclesWhiles_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, min, max, i;

            Console.WriteLine("Dime el primer número");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número");
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
            i = min;
            while (i <= max)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }

                i++;
            }



          

        }
    }
}

