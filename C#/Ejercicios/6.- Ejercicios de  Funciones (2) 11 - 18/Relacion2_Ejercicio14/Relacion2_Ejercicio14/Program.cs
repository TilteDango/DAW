using System;

namespace Relacion2_Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            LeeNatural();
        }

        static int LeeNatural ()
        {
            int a;
            Console.WriteLine("Número para leer");
            a = int.Parse(Console.ReadLine());

            while (a <= 0)
            {
                Console.WriteLine("Número no válido, vuelva a introducirlo");
                a = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine(a);

            return a;
        }
    }
}
