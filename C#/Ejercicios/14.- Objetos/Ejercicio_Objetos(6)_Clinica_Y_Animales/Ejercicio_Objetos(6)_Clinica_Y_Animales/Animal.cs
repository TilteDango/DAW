using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Objetos_6__Clinica_Y_Animales
{
    abstract class  Animal
    {
        protected string nombre;
        protected DateTime fechaNacimiento;
        protected double peso;
        protected string comentarios;

        public string Nombre { get => nombre; }
        public DateTime FechaNacimiento { get => fechaNacimiento; }
        public double Peso { get => peso; set => peso = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }

        public Animal(string nombre, DateTime fechaNacimiento, double peso)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;
            this.comentarios = " No tiene comentarios todavía";
        }

        public abstract override string ToString();
    }
}
