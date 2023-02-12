using System;

namespace Examen_Programacion_Ej4
{
    class Program
    {
        static void Main(string[] args)
        {

            SmartArray array = new SmartArray(5);

            array[0] = 9;
            array[1] = 12;
            array[2] = 7;
            array[3] = 40;
            array[4] = 1;
            SmartArray array2 = new SmartArray(5);
            array2[0] = 9;
            array2[1] = 12;
            array2[2] = 7;
            array2[3] = 40;
            array2[4] = 1;

            Console.WriteLine(array == array2);
            Console.WriteLine(array != array2);

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}


            //Console.WriteLine(array);
            //array.Shuffle();
            //Console.WriteLine(array);
            //array.Sort();
            //Console.WriteLine(array);
            //array.Reverse();
            //Console.WriteLine(array);
        }


    }
}
