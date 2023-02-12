using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Examen_Programacion_Ej3
{
    class PixelDrawing
    {
        private List<Pixel> pixels = new List<Pixel>();

        public List<Pixel> Pixels { get => pixels; }

        public void SaveToFile(string filename)
        {

            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            for (int i = 0; i < pixels.Count; i++)
            {
                bw.Write(pixels[i].X);
                bw.Write(pixels[i].Y);
            }
            bw.Close();
            fs.Close();
        }

        public void LoadFromFile(string filename)
        {
            int x, y;
            FileStream fs = new FileStream(filename, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                x = br.ReadInt32();
                y = br.ReadInt32();
                pixels.Add(new Pixel(x, y));
            }
            br.Close();
            fs.Close();
        }

        public void Draw()
        {
            string s = "█";
            for (int i = 0; i < pixels.Count; i++)
            {
                Console.SetCursorPosition(pixels[i].X, pixels[i].Y);
                Console.Write(s);
            }
        }


        public override string ToString()
        {
            int x, y;
            string[,] map = new string[10, 10];
            string s = "";

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int k = 0; k < map.GetLength(1); k++)
                {
                    map[i, k] = " ";
                }
            }

            for (int i = 0; i < pixels.Count; i++)
            {
                x = pixels[i].X;
                y = pixels[i].Y;

                map[x, y] = "█";
            }

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int k = 0; k < map.GetLength(1); k++)
                {
                    s += map[k, i];
                }
                s += "\n";
            }

            return s;
        }
    }
}
