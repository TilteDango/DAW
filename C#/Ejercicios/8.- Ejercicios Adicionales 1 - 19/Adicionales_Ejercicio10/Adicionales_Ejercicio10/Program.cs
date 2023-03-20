using System;

namespace Adicionales_Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            EscribeSerieNumero3();
        }

        static void EscribeSerieNumero3()
        {
            int a, b, c;

            Console.Write("Dime el primer número (1,100): ");
            a = int.Parse(Console.ReadLine());

            while (a > 100 || a < 1)
            {
                Console.Write("El número no es correcto, vuelve a introducirlo: ");
                a = int.Parse(Console.ReadLine());
            }

            Console.Write("Dime el segundo número(1º,100): ");
            b = int.Parse(Console.ReadLine());

            while ((b < a) || (b < 1) || (b > 100))
            {
                Console.Write("El número no es correcto, vuelve a introducirlo: ");
                b = int.Parse(Console.ReadLine());
            }
            
            Console.Write("Dime el tercer número(1º,2º): ");
            c = int.Parse(Console.ReadLine());

            while (c > 100 || c < 1 || c < a || c > b)
            {
                Console.Write("El número no es correcto, vuelve a introducirlo: ");
                c = int.Parse(Console.ReadLine());
            }

            for (int i = a; i <= c; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int i = c; i <= b; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
