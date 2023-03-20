using System;

namespace Adicionales_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string decidir;
            double n;
            Console.WriteLine("a) Grados Fahrenheit");
            Console.WriteLine("b) Grados Centigrados");
            Console.WriteLine("¿Que calculamos?(a/b): ");
            decidir = Console.ReadLine();
            
            if (decidir == "a" || decidir == "A") 
            {
                Console.Write("Dime los grados centigrados: ");
                n = double.Parse(Console.ReadLine());

                Console.WriteLine("Los grados fahrenheit son: " + CentigradosAFahrenheit(n));
            }
            else
            {

                Console.Write("Dime los grados fahrenheit: ");
                n = double.Parse(Console.ReadLine());

                Console.WriteLine("Los gardos centigrados son: " + FahrenheitACentigrados(n));
            }
        }

        static double CentigradosAFahrenheit( double n)
        {
            double a;
            a = 1.8 * n + 32;

            return a;
        }

        static double FahrenheitACentigrados(double n)
        {
            double a;
            a = (n - 32) / 1.8;

            return a;
        }
    }
}
