using System;

namespace Estructurada_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("Dime el número X");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el número Y");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el número Z");
            z = int.Parse(Console.ReadLine());

            if ((x < y) && (y < z))
            {
                Console.WriteLine("El menor es " + x + ",  el del medio es " + y + ", y el mayor es " +z);
            }
            else
            {
                if ((x > y) && (y > z))
                {
                    Console.WriteLine("El menor es " + z + ",  el del medio es " + y + ", y el mayor es " + x);

                }
                else
                {
                    if ((x < y) && (y > z))
                    {
                        Console.WriteLine("El menor es " + x + ",  el del medio es " + z + ", y el mayor es " + y);

                    }
                    else
                    {
                        if ((x > y) && (x < z))
                        {
                            Console.WriteLine("El menor es " + y + ",  el del medio es " + x + ", y el mayor es " + z);

                        }
                        else
                        {
                            if ((x < y) && (x > z))
                            {
                                Console.WriteLine("El menor es " + y + ",  el del medio es " + x + ", y el mayor es " + z);

                            }
                            else
                            {
                                Console.WriteLine("El menor es " + y + ",  el del medio es " + z + ", y el mayor es " + x);

                            }
                        }
                    }
                }
            }
        }
    }
}


