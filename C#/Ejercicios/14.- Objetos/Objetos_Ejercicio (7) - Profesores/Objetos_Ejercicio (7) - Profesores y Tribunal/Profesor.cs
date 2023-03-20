using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Objetos_Ejercicio__7____Profesores_y_Tribunal
{
    enum TipoGenero
    {
        Hombre, Mujer
    }
    class Profesor : IComparable<Profesor>
    {
        private string nombre;
        private string dni;
        private TipoGenero genero;
        

       public Profesor (string nombre, string dni, TipoGenero genero)
        {
            this.nombre = nombre;

            this.dni = dni;
            
            this.genero = genero;
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                if (value == null)
                {
                    throw new Exception("El nombre no puede estar vacío");
                }
                else
                {
                    this.nombre = value;
                }
            }
        }
                 
 
        public string Dni { get => dni; 
            set {
                if (value.Length != 9)
                {
                    throw new Exception("El DNI no es válido");
                }
                else
                {
                    this.dni = value;
                }
            } }
        public TipoGenero Genero { get => genero; set => genero = value; }
        private String Dniinvertido
        {
            get
            {
                string s = "";
                for (int i = dni.Length -2; i > 0; i--)
                {
                    s += dni[i];
                }
                return s;
            }
        }

        public int CompareTo([AllowNull] Profesor other)
        {
            return this.Dniinvertido.CompareTo(other.Dniinvertido);
        }

        public override string ToString()
        {
            return nombre + " - " + dni;
        }

    }
}
