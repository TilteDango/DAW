using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Programacion_Ej3
{
    class Pixel
    {
        private int x;
        private int y;

        public Pixel(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X
        {
            get => x;
            set
            {
                if (value >= 0 && value <= 9)
                {
                    this.x = value;
                }
                else
                {
                    throw new Exception("El valor es inválido");
                }
            }

        }
        public int Y { get => y;
            set
            {
                if (value >= 0 && value <= 9)
                {
                    this.y = value;
                }
                else
                {
                    throw new Exception("El valor es inválido");
                }
            }
        }
    }
}
