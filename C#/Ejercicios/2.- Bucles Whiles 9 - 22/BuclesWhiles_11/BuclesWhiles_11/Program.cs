using System;

namespace BuclesWhiles_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, cont;
            i = 0;
            cont = 0;

            while (cont <= 10)
            {
                
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    cont = cont + 1;
                }
                i++;
            }
        }
    }
}
