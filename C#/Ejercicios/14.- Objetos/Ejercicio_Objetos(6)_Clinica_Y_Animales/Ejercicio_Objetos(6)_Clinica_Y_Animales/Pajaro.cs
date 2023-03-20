using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Objetos_6__Clinica_Y_Animales
{
    enum EspeciePajaro
    {
        Canario, Periquito, Agapornis
    }
    class Pajaro : Animal
    {
        private EspeciePajaro especie;
        private bool cantor;

        public Pajaro(string nombre, DateTime fechaNacimiento, double peso, EspeciePajaro especie, bool cantor) : base(nombre, fechaNacimiento, peso)
        {
            this.especie = especie;
            this.cantor = cantor;
        }

        public bool Cantor { get => cantor;}
        internal EspeciePajaro Especie { get => especie;}

        public override string ToString()
        {
            string s;
            if (cantor)
            {
                s = "Da por culo por las mañanas";
            }
            else
            {
                s = "Mas callao que un cura";
            }

            return "Ficha de Pajaro".PadLeft(22) + "\n" + "".PadRight(30, '-') + "\n Nombre: " + nombre + "\n Especie: " + especie + "\n Fecha de Nacimiento: " + fechaNacimiento.ToShortDateString() + "\n Peso: " + peso + "\n Cantor: " + s + "\n Comentarios: " + comentarios;

        }
    }
}
