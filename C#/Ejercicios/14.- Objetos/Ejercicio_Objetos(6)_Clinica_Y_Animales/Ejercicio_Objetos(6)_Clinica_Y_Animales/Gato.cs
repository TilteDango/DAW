using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Objetos_6__Clinica_Y_Animales
{
    enum RazaGato
    {
        Comun, Siames, Persa, Angora, ScottishFold
    }
    class Gato : Animal
    {
        private RazaGato raza;
        private string microchip;

        protected RazaGato Raza { get => raza;}
        protected string Microchip { get => microchip;}

        public Gato(string nombre, DateTime fechaNacimiento, double peso, RazaGato raza, string microchip) : base(nombre, fechaNacimiento, peso)
        {
            this.raza = raza;
            this.microchip = microchip;
        }

        public override string ToString()
        {
            return "Ficha de Gato".PadLeft(20) + "\n" + "".PadRight(30, '-') + "\n Nombre: " + nombre + "\n Raza: " + raza + "\n Fecha de Nacimiento: " + fechaNacimiento.ToShortDateString() + "\n Peso: " + peso + "\n Microchip: " + microchip + "\n Comentarios: " + comentarios;

        }


    }
}
