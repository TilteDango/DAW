using System;

namespace BuclesFor_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Dime un núumero");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime otro núumero");
            b = int.Parse(Console.ReadLine());

            if (a < b)
           
            {
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine(i);
                }
            }

            else
            {
                for (int i = a; i >= b; i--)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
