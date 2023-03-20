using System;

namespace Relacion1_Funcion3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Las tablas de multiplicar");
            Console.WriteLine();
            Console.Write("Dime un número: " );
            n = int.Parse(Console.ReadLine());
            TablaMultiplicar(n);
        }

        static void TablaMultiplicar(int n)
        {
            int i = 1, suma;
            while (i <= 10)
            {
                suma = n * i;

                Console.WriteLine(n + " * " + i + " = " + suma);

                i++;
            }
        }
    }

  
}
