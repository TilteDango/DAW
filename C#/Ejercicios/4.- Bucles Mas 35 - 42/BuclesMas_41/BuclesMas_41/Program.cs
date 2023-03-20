using System;

namespace BuclesMas_41
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, cont = 0, k; 
           
            for (int i = 2; i <= 1000; i++)
            {
                cont = 0;

                k = i;
                while (k >= 1)
                {
                    if (i % k == 0)
                    {
                        cont++;
                    }
                    k--;
                }
                if (cont == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
