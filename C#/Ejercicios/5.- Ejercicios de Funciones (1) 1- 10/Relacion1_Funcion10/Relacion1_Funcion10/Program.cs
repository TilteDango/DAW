using System;

namespace Relacion1_Funcion10
{
    class Program
    {
        static void Main(string[] args)
        {
            int  a;
            Console.WriteLine("Vamos a averiguar si el núemro es primo o no");
            Console.WriteLine();
            Console.Write("Dime un número: ");
            a = int.Parse(Console.ReadLine());

            if (Primo(a))
            {
                Console.WriteLine("Tu número es primo");
            }
            else
            {
                Console.WriteLine("Tu número no es primo");
            }
        }

        static bool Primo(int n)
        {
            int cont;
            cont = 0;
            for (int i = n - 1; i > 1; i--)
            {
                if (n % i == 0)
                {
                    cont = cont + 1;
                    i = 1;
                }
            }

            if (cont == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
