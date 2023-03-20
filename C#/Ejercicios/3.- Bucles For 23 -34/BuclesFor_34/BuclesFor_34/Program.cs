using System;

namespace BuclesFor_34
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, fact;
            fact = 1;
            Console.WriteLine("Dime un número");
            n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                fact = fact * i;
            }

            Console.WriteLine("EL valor factorial es " + fact);
        }
    }
}
