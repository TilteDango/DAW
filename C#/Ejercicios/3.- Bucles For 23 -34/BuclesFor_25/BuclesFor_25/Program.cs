using System;

namespace BuclesFor_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 0;

            for (int cont = 0; cont <= 10; cont++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    i = i + 2;
                }

      
            }
        }
    }
}
