using System;

namespace Relacion1_Funcion4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Vamos a decir todos los números comprendidos entre dos numeros");
            Console.Write("Dime el primero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Dime el segundo: ");
            b = int.Parse(Console.ReadLine());

            imprimeSerie(a, b);
        }

        static void imprimeSerie ( int a, int b)
        {
            
            if (a > b)
            {
                for (int i = a - 1; i > b; i--)
                {
                    Console.WriteLine(i);
                }
            }

            else
            {
                for (int i = a + 1; i < b; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
