using System;

namespace BulcesWhiles_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b;

            Console.WriteLine("Dime dos números de menos a mayor");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el otro número");
            b = int.Parse(Console.ReadLine());

            while (a > b)
            {
                Console.WriteLine("Así no es, dime otra vez los números");
                 a = int.Parse(Console.ReadLine());
                Console.WriteLine("Dime el otro número");
                b = int.Parse(Console.ReadLine());
            }

            n = a;

            while (a <= b)
            {
                Console.WriteLine(a);

                a++;
            }
        }
    }
}
