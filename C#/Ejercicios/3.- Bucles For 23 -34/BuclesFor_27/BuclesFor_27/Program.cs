using System;

namespace BuclesFor_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, h;
            h = 0;
            Console.WriteLine("Dime un número");
            a = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(a + " * " + i + " = " + h);

                h = h + a;
            }
        }
    }
}
