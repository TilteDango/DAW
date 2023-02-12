using System;

namespace Estructurada_05
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

            if (x + 1 == y)
            {
                if (y + 1 == z)
                {
                    Console.WriteLine("Los números son consecutivos");
                }
            }
            else
            {
                Console.WriteLine("Los números no son consecutivos");
            }
        }
    }
}