using System;

namespace Estructurada_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, ecuacion, resultado1, resultado2;
            Console.WriteLine("Escribeme el coeficiente a");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Escribeme el coeficiente b");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Escribeme el coeficiente c");
            c = double.Parse(Console.ReadLine());

            ecuacion = (b * b) - 4 * a * c;

            if (ecuacion < 0)
            {

                Console.WriteLine("No se puede hacer");

            }
            else
            {
                if (ecuacion > 0)
                {
                    resultado1 = (-b + Math.Sqrt((ecuacion)) / (2 * a));
                    resultado2 = (-b - Math.Sqrt((ecuacion)) / (2 * a));

                    Console.WriteLine("Solución 1: " + resultado1);
                    Console.WriteLine("Solución 2: " + resultado2);
                }
                else
                {
                    resultado1 = (-b / (2 * a));
                    Console.WriteLine("Solución: " + resultado1);
                }
            }
        }


    }
}
