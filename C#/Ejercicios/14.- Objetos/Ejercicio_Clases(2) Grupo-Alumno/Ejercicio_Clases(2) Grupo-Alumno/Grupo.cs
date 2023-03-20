using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ejercicio_Clases_2__Grupo_Alumno
{
    class Grupo
    {
        private List<Alumno> l;


        public Grupo ()
        {
            l = new List<Alumno>();
        }

        public void InsertaAlumnoLista(Alumno a)
        {
            l.Add(a);
        }

        public void InsertaAlumnoLista(string nombre, int edad, double calificacion)
        {
            Alumno a = new Alumno(nombre, edad, calificacion);
            l.Add(a);
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < l.Count; i++)
            {
                s = s + l[i] + "\n" + "----------------------" + "\n";
            }

            return s;
        }

        public void EscribeFicheroBinario(string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            int n = l.Count;
            bw.Write(n);

            for (int i = 0; i < l.Count; i++)
            {
                bw.Write(l[i].Nombre);
                bw.Write(l[i].Edad);
                bw.Write(l[i].Calificacion);
            }

            bw.Close();
            fs.Close();
        }

        public void LeeFicheroBinario(string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            l.Clear();
            string nombre;
            int edad;
            double calificacion;
            int n = br.ReadInt32();

            while (fs.Position < fs.Length)
            {
                
                nombre = br.ReadString();
                edad = br.ReadInt32();
                calificacion = br.ReadDouble();
                Alumno h = new Alumno(nombre, edad, calificacion);
                l.Add(h);               
            }



            br.Close();
            fs.Close();

        }

        public void EscribeFicheroTexto(string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);
            for (int i = 0; i < l.Count; i++)
            {
                sw.WriteLine(l.Count);
                sw.WriteLine(l[i].Nombre);
                sw.WriteLine(l[i].Edad);
                sw.WriteLine(l[i].Calificacion);
            }

            sw.Close();
        }

        public void LeeFicheroAlumnosTexto(string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            string nombre;
            int edad;
            double calificacion;
            int n = int.Parse(sr.ReadLine());
            l.Clear();

            for (int i = 0; i < n; i++)
            {
                nombre = sr.ReadLine();
                edad = int.Parse(sr.ReadLine());
                calificacion = double.Parse(sr.ReadLine());
                Alumno h = new Alumno(nombre, edad, calificacion);
                l.Add(h);
            }

        }

        public void EscribeFicheroCSV(string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);

            for (int i = 0; i < l.Count; i++)
            {
                sw.Write($"{l[i].Nombre}" + ";");
                sw.Write($"{l[i].Edad}" + ";");
                sw.Write($"{l[i].Calificacion}" + ";");
                sw.WriteLine();
            }

            sw.Close();
        }

        public void LeeFicheroAlumnosCSV(string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            l.Clear();
            string[] palabras;
            string nombre;
            int edad;
            double calificacion;
            while (!sr.EndOfStream)
            {
                palabras = sr.ReadLine().Split(';');

                for (int i = 0; i < palabras.Length - 3; i = i + 3)
                {
                    nombre = palabras[i];
                    edad = int.Parse(palabras[i + 1]);
                    calificacion = double.Parse(palabras[i + 2]);
                    Alumno h = new Alumno(nombre,edad,calificacion);
                    l.Add(h);
                }

            }
            sr.Close();
        }
    }
}
