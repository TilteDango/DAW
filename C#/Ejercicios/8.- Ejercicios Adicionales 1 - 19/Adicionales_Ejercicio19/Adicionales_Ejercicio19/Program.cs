using System;

namespace Adicionales_Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Vamos a calcular la progresión aritmética de dos números");
            Console.WriteLine();
            Console.Write("Dime el primer número: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Dime el segundo número: ");
            b = int.Parse(Console.ReadLine());

            ProgresionAritmetica(a, b);
        }

        static void ProgresionAritmetica ( int a, int b)
        {
            int progresion, diferencia;
            
                diferencia = b - a;
                progresion = a;
                Console.Write(a + " ");
                for (int i = 1; i < 10; i++)
                {
                    progresion = progresion + diferencia;
                    Console.Write(progresion + " ");

                    
                }
           
        }

    }
}
