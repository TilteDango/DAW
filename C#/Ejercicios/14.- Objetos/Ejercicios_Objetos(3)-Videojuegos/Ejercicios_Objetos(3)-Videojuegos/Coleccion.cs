using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ejercicios_Objetos_3__Videojuegos
{
    class Coleccion
    {
        List<Videojuego> l = new List<Videojuego>();

        public void InsertaVideojuego(Videojuego v)
        {
            l.Add(v);
        }

        public void EliminaVideojuego (int posicion)
        {
            l.RemoveAt(posicion);
        }

        public Videojuego LeeVideojuego(int posicion)
        {
            return l[posicion];
        }

        public void GuardaColeccionFichero (string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);

            for (int i = 0; i < l.Count; i++)
            {
                sw.WriteLine(l[i].Nombre + ";" + l[i].Anno +";"+ (int)l[i].Paltaforma +";" + (int)l[i].Paltaforma + ";" + l[i].Valoracion);
            }

            sw.Close();
        }
        
        public void LeeColeccionFichero (string fichero)
        {
            l.Clear();
            string nombre;
            int anno;
            Plataforma plataforma;
            TipoJuego tipoJuego;
            int valoracion;
            StreamReader sr = new StreamReader(fichero);
            string[] palabras;
      
            while (!sr.EndOfStream)
            {
                palabras = sr.ReadLine().Split(";");
                nombre = palabras[0];
                anno = int.Parse(palabras[1]);
                plataforma = (Plataforma)int.Parse(palabras[2]);
                tipoJuego = (TipoJuego)int.Parse(palabras[3]);
                valoracion = int.Parse(palabras[4]);
                Videojuego v = new Videojuego(nombre, anno, plataforma, tipoJuego, valoracion);
                l.Add(v);
                
            }

            sr.Close();
        }

        public string ToStringNum()
        {
            string s = "";
            for (int i = 0; i < l.Count; i++)
            {
                s = s + (i+1) + "- " + l[i].Nombre + "\n";
            }
            return s;
        }
        public override string ToString()
        {
            string s = "";
            s = "Videojuego".PadRight(30) + "Año".PadRight(8) + "Plataforma".PadRight(20) + "Tipo de juego".PadRight(20) + "Val.".PadLeft(3) + "\n" + "-----------------------------------------------------------------------------------------" + "\n";

            for (int i = 0; i < l.Count; i++)
            {
                s = s + l[i] + "\n";
            }

            return s;
        }

       
    }


    
}
