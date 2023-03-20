using System;

namespace Objetos_4____Fracciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraccion f1 = new Fraccion(2, 3);
            Fraccion f2 = new Fraccion(3, 4);
            Console.WriteLine(f1 + "          " + f2);
            Console.WriteLine();
            Console.WriteLine("1. Suma las dos fracciones");
            Console.WriteLine(f1+f2);
            Console.WriteLine();
            Console.WriteLine("2. Resta las dos fracciones");
            Console.WriteLine(f1 - f2);
            Console.WriteLine();
            Console.WriteLine("3. Multiplica las dos fracciones");
            Console.WriteLine(f1 * f2);
            Console.WriteLine();
            Console.WriteLine("4. Divide las dos fracciones");
            Console.WriteLine(f1 / f2);
            Console.WriteLine();
            Console.WriteLine("5. ¿La primera fraccion es igual que la segunda?");
            Console.WriteLine(f1 == f2);
            Console.WriteLine();
            Console.WriteLine("6. ¿La primera fraccion es menor que la segunda?");
            Console.WriteLine(f1 < f2);
            Console.WriteLine();
            Console.WriteLine("7. ¿La primera fraccion es mayor que la segunda?");
            Console.WriteLine(f1 > f2);
            Console.WriteLine();
            Console.WriteLine("8. ¿La primera fraccion es menor o igual que la segunda?");
            Console.WriteLine(f1 <= f2);
            Console.WriteLine();
            Console.WriteLine("9. ¿La primera fraccion es mayor o igual que la segunda?");
            Console.WriteLine(f1 >= f2);
        }
        
    }
}
