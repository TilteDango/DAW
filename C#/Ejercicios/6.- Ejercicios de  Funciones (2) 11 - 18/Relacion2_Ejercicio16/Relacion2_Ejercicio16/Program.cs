using System;

namespace Relacion2_Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Vamos a elevar los número ");
            Console.WriteLine();
            Console.Write("Dime el número base: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Dime el número elevador: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es " + Elevado(a, b)); 

        }

        static int Elevado (int a, int b)
        {

            int resultado = 1;
            
            
            for (int i = 1; i <= b ; i++)
            {
                resultado = resultado * a;
            }

            return resultado;

            
        }
    }
}
