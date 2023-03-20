using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Objetos_6__Clinica_Y_Animales
{
    class ClinicaVeterinaria
    {
        private List<Animal> listaAnimales = new List<Animal>();

        public void InsertaAnimal(Animal a)
        {
            listaAnimales.Add(a);
        }

        public Animal BuscaAnimal (string nombre)
        {
            for (int i = 0; i < listaAnimales.Count; i++)
            {
                if (listaAnimales[i].Nombre == nombre)
                {
                    return listaAnimales[i];
                }
            }

            return null;
        }

        public void ModificaComentarioAnimal (string nombre, string coment)
        {
            for (int i = 0; i < listaAnimales.Count; i++)
            {
                if (listaAnimales[i].Nombre == nombre)
                {
                    listaAnimales[i].Comentarios = coment;
                }   
            }


        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < listaAnimales.Count; i++)
            {
                s += listaAnimales[i] + "\n";
                s += "".PadRight(30, '=') + "\n"; 
            }

            return s;
        }
    }
}
