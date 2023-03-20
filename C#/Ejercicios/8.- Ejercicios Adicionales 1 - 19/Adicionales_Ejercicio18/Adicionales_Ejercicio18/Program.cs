using System;

namespace Adicionales_Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Introduce la cantidad de números que quieres sumar: ");
            n = int.Parse(Console.ReadLine());

            SumaNumeros(n);
        }

        static void SumaNumeros(int n)
        {
            int suma, total = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Dime el número " + i + ": ");
                suma = int.Parse(Console.ReadLine());
               
                while (suma < 0)
                {
                    Console.Write("Nota no válida, vuelve a introducirla: ");
                    suma = int.Parse(Console.ReadLine());
                    
                }

                total = total + suma;
            }
            Console.WriteLine("La suma de los números es: " + total);
        }
    }
}
