using System;

namespace Adicionales_Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura, longitud;
            Console.Write("Introduzca la altura del romboide: ");
            altura = int.Parse(Console.ReadLine());

            Console.Write("Introduzca la longitud del romboide: ");
            longitud = int.Parse(Console.ReadLine());

            Romboide(altura, longitud);
        }

        static void Romboide(int altura, int longitud)
        {
            int n;
           
                n = altura;
                for (int j = 1; j <= altura; j++)
                {


                    for (int i = n; i > 1; i--)
                    {
                        Console.Write(" ");
                    }

                    for (int i = 1; i <= longitud; i++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                    n--;
                }
           
            
        }
    }
}
