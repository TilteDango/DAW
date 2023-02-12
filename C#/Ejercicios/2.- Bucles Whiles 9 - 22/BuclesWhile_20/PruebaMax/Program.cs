using System;

namespace PruebaMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, max;
            i = 0;
            max = 0;
            while (i <= 10)
            {
                Console.WriteLine("Dime el número " +  i);
                n = int.Parse(Console.ReadLine());

                if (max <= n)
                {
                    max = n;
                }
                
                i++;
            }

            Console.WriteLine("El número máximo sería " + max);
        }
    }
}
