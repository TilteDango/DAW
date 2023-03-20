using System;

namespace BuclesMas_37
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;


            Console.WriteLine("¿Qué prefieres? (a/b/c)");
            n = Console.ReadLine();

            while (!(n == "a" || n == "b" || n == "c"))
            {
                Console.WriteLine("Opción invalida (a/b/c)");
                n = Console.ReadLine();
            }

            if (n == "a")
            {
                for (int i = 1; i < 100; i++)
                {
                    if (i % 11 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                if (n == "b")
                {
                    for (int i = 1; i < 100; i++)
                    {
                        if (i % 17 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else
                {
                    for (int i = 1; i < 100; i++)
                    {
                        if (i % 23 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }

        }
    }
}
