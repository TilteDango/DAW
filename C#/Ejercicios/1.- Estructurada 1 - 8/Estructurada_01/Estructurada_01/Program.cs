using System;

namespace Estructurada_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, resultado;

            Console.WriteLine("Dime el número A");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Dime el número B");
            b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                resultado = (a - b);
            }
            else
            {
                resultado = (b - a);
            }

            Console.WriteLine("El resultado es " + resultado);
        }
    }
}