using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Clases_2__Grupo_Alumno
{
    class Alumno
    {
        private string nombre;
        private int edad;
        private double calificacion;

        public Alumno(string nombre, int edad, double calificacion)
        {
            if (nombre != null)
            {
                this.nombre = nombre;
            }
            else
            {
                throw new Exception("No puede ser una cadena vacia");
            }

            if (edad > 17 && edad < 100)
            {
                this.edad = edad;
            }
            else
            {
                throw new Exception("No es una edad válida, tiene que estar entre 17 y 100");
            }

            if (calificacion > 0 && calificacion < 10)
            {
                this.calificacion = calificacion;
            }
            else
            {
                throw new Exception("No es una calificación válida, tiene que estar entre 0 y 10");
            }
        }

        public string Nombre { get => nombre;}
        public int Edad { get => edad;}
        public double Calificacion { get => calificacion;}

        public override string ToString()
        {
            string s = "";

            s = "Nombre: " +nombre + "\n" + "Edad: " + edad + "\n" + "Calificación: " + calificacion;

            return s;
        }
    }
}

   
