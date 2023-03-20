using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Objetos_6__Clinica_Y_Animales
{
    enum EspecieReptil
    {
        Tortuga, Iguana, DragonDeComodo
    }
    class Reptil : Animal
    {
        private EspecieReptil especie;
        private bool venenoso;

        public Reptil(string nombre, DateTime fechaNacimiento, double peso, EspecieReptil especie, bool venenoso) : base(nombre, fechaNacimiento, peso)
        {
            this.especie = especie;
            this.venenoso = venenoso;
        }

        public bool Venenoso { get => venenoso;}
        internal EspecieReptil Especie { get => especie;}

        public override string ToString()
        {
            string s;
            if (venenoso)
            {
                s = "Ten cuidao que te mata";
            }
            else
            {
                s = "No mata ni a una mosca";
            }

            return "Ficha de Reptil".PadLeft(22) + "\n" + "".PadRight(30, '-') + "\n Nombre: " + nombre + "\n Especie: " + especie + "\n Fecha de Nacimiento: " + fechaNacimiento.ToShortDateString() + "\n Peso: " + peso + "\n Venenosos: " + s + "\n Comentarios: " + comentarios;

        }
    }
}
