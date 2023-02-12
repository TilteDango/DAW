using System;
using System.IO;

namespace Examen_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CompruebaCoordenadas("tarjeta5x5.cdn"));
        }

        static bool CompruebaCoordenadas (string fichero)
        {
            Random r = new Random();
            
            FileStream fs = new FileStream(fichero, FileMode.Open); 
            BinaryReader br = new BinaryReader(fs);
            string[,] tarjeta = new string[br.ReadInt32(), br.ReadInt32()];
            int col = r.Next(0, tarjeta.GetLength(1)), row = r.Next(0,tarjeta.GetLength(0));
            string palabra;
            bool final;
            for (int x = 0; x < tarjeta.GetLength(0); x++)
            {
                for (int y = 0; y < tarjeta.GetLength(1); y++)
                {
                    tarjeta[x,y] = br.ReadString();
                }
            }


            Console.Write("Necesito que me introduzcas la cadena de " + (row+1) + "," + (col+1) + ": ");
            palabra = Console.ReadLine();
           
            if (palabra == tarjeta[row, col]) 
            {
                final = true;
            }
            else
            {
                final =  false;
            }

            br.Close();
            fs.Close();

            return final;
  
        }
    }
}
