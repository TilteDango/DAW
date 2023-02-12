using System;

namespace Estructurada04
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Dime el número X");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el número Y");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el número Z");
            z = int.Parse(Console.ReadLine());

            if (x < y)
            {
                if (y < z)
                {
                    Console.WriteLine("Están ordenados de menor a mayor");
                }
            }
            else
            {
                Console.WriteLine("No están ordenador de menor a mayor");
            }

        }
    }
}
