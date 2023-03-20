using System;

namespace BuclesFor_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, j, p;
            j = 0;
            p = 0;
            for (int i = 0; i <= 30; i++)
            {
                Console.WriteLine("Dime la nota " + i);
                h = int.Parse(Console.ReadLine());
                if ((h < 0) || (h > 10))
                {
                    Console.WriteLine("La nota es incorrecta");
                    i--;
                }
                else
                {
                    if (h >= 5)
                    {
                        j++;
                    }
                    else
                    {
                        p++;
                    }
                }
            }

            Console.WriteLine("Tienes " + j + " aprobados y " + p + " suspendidos.");
        }
    }
}
