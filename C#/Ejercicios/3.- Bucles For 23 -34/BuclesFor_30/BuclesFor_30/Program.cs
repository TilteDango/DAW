using System;

namespace BuclesFor_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 0;
            for (int i = 2; i <= 1000; i = i + 2)
            {
                a = a + i;

            }
            Console.WriteLine("La suma es " + a);
        }
    }
}
