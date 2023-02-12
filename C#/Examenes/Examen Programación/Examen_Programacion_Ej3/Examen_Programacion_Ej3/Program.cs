using System;

namespace Examen_Programacion_Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            PixelDrawing pd = new PixelDrawing();

            pd.LoadFromFile("chess.bin");


            Console.WriteLine(pd);
        }
    }
}
