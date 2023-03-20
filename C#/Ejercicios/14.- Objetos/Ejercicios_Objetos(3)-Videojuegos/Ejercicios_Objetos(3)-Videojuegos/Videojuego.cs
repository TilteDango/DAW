using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Objetos_3__Videojuegos
{
    class Videojuego
    {
        private string nombre;
        private int anno;
        private Plataforma plataforma;
        private TipoJuego tipoJuego;
        private int valoracion;

        public string Nombre { get => nombre; 
            set {
                if (value == null)
                {
                    throw new Exception("El nombre tiene que tener caracteres");
                }
                else
                {
                    this.nombre = value;
                }
            }  
        }
        public int Anno
        {
            get => anno;
            set
            {
                if (value > 1970 && value < 2100)
                {
                    this.anno = value;
                }
                else
                {
                    throw new Exception("El año no es válido, debe estar comrpendido entre 1970 y 2100");
                }
            }
        }
        public Plataforma Paltaforma { get => plataforma; set => plataforma = value; }
        public TipoJuego TipoJuego { get => tipoJuego; set => tipoJuego = value; }
        public int Valoracion
        {
            get => valoracion; set
            {
                if (value >= 0 && value <= 100)
                {
                    this.valoracion = value;
                }
                else
                {
                    throw new Exception("La puntuación debe estar entre 0 y 100");
                }
            }
        }

        public Videojuego(string nombre, int anno, Plataforma plataforma, TipoJuego tipoJuego, int valoracion)
        {
            this.nombre = nombre;
            this.anno = anno;
            this.plataforma = plataforma;
            this.tipoJuego = tipoJuego;
            this.valoracion = valoracion;
        }

        public override string ToString()
        {
            string s = "";
            s = nombre.PadRight(30) + anno.ToString().PadRight(8) + plataforma.ToString().Replace("_"," ").PadRight(20) + tipoJuego.ToString().PadRight(20) + valoracion.ToString().PadLeft(3);
            return s;

           
        }
    }
}
