using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Objetos_6__Clinica_Y_Animales
{
    enum RazaPerro
    {
        PastorAleman, Husky, FoxTerrier, Dalmata, SanBernardo
    }
    class Perro : Animal
    {
        private RazaPerro raza;
        private string microchip;

        protected RazaPerro Raza { get => raza; }
        protected string Microchip { get => microchip; }

        public Perro(string nombre, DateTime fechaNacimiento, double peso, RazaPerro raza, string microchip) : base(nombre, fechaNacimiento, peso)
        {
            this.raza = raza;
            this.microchip = microchip;
        }

        public override string ToString()
        {
            return "Ficha de Perro".PadLeft(22) + "\n" + "".PadRight(30,'-')  + "\n Nombre: " + nombre + "\n Raza: " + raza + "\n Fecha de Nacimiento: " + fechaNacimiento.ToShortDateString()  + "\n Peso: " + peso + "\n Microchip: " + microchip + "\n Comentarios: " + comentarios;

        }
    }
}
