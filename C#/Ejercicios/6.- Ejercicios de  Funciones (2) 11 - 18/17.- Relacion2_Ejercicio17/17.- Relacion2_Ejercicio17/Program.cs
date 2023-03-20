using System;

namespace _17.__Relacion2_Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Vamos a calcular el valor factorial de un número entero");
            Console.WriteLine();
            Console.Write("Dime un número: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("El valor factorial es " + Factorial(n));
        }

        static int Factorial (int n)
        {
            int i = 1, res = 1;

            while (i <= n)
            {
                res = res * i;

                i++;
            }

            return res;
        }
    }
}
