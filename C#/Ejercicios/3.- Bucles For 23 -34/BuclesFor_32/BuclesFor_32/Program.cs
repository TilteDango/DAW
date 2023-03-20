using System;

namespace BuclesFor_32
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, n;
            max = 0;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Dime el número " + i);
                n = int.Parse(Console.ReadLine());
                if (max <= n)
                {
                    max = n;
                }
            }

            Console.WriteLine("El número más alto es " + max);
        }
    }
}
