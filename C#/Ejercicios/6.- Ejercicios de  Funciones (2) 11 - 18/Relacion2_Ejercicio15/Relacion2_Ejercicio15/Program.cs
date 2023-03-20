using System;

namespace Relacion2_Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Dime un número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime otro número");
            b = int.Parse(Console.ReadLine());

            LeeNumero(a, b);

        }

        static void LeeNumero(int a, int b)
        {
            int temp;
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp; 
            }
            
            Random r = new Random();
            int n = r.Next(a, b + 1);

            Console.WriteLine();
            Console.WriteLine(n);
        }
    }
}
