using System;

namespace BuclesMas_36
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            k = 0;

            for (int i = 0; k < 10; i++)
            {
                if ((i % 2 != 0) && (i % 3 != 0))
                {
                    Console.WriteLine(i);
                    k++;
                }
            }
        }
    }
}
