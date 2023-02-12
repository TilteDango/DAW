using System;

namespace BuclesWhile_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            
            Console.WriteLine("Dime el primer número");
            a = int.Parse(Console.ReadLine());
        
            Console.WriteLine("Dime el segundo número");
            b = int.Parse(Console.ReadLine());

            if (a < b)
            {

                while (a <= b)
                {
                    Console.WriteLine(b);

                    a++;
                }
            }

            else
            {
                while (b <= a)
                {
                    Console.WriteLine(a);

                    a--;
                }
            
            }

        }

    }
}
