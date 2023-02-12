using System;

namespace BuclesWhiles_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, fact;
            fact = 1;
            Console.WriteLine("Dime un número que quiera el factorial");
            n = int.Parse(Console.ReadLine());
           
            i = n;
            while (i >= 1)
            {
                fact = fact * i;
                i--;
            }

            Console.WriteLine("El número sería " + fact);
        }
    }
}
