using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ejercicio_Objetos__10__Venta_De_Coches
{
    class AutoVenta
    {
        public List<Coche> listaCoches = new List<Coche>();

        public void CargaCSV (string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            string[] datos;
            string[] f;
            string matricula, marca, modelo;
            double precio;
            int dia, mes, anno;
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                datos = sr.ReadLine().Split(';');

                matricula = datos[0];
                f = datos[3].Split('/');
                dia = int.Parse(f[0]);
                mes = int.Parse(f[1]);
                anno = int.Parse(f[2]);
                marca = datos[1];
                modelo = datos[2];
                precio = double.Parse(datos[4]);
                Coche a = new Coche(matricula, new DateTime(anno, mes, dia), marca, modelo, precio);
                listaCoches.Add(a);
            }

            sr.Close();
        }

        public void GuardaCSV (string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);

            sw.WriteLine("Matricula;Marca;Modelo;FechaDeMatricualcion;Precio");

            for (int i = 0; i < listaCoches.Count; i++)
            {
                sw.WriteLine(listaCoches[i].Matricula + ";" + listaCoches[i].Marca
                    + ";" + listaCoches[i].Modelo + ";" + listaCoches[i].FechaMatriculacion.ToShortDateString() + ";"
                    + listaCoches[i].Precio);
            }

            sw.Close();
        }

        public void InsertaCoche(Coche c)
        {
            listaCoches.Add(c);
        }

        public Coche BuscaCoche(string matricula)
        {
            for (int i = 0; i < listaCoches.Count; i++)
            {
                if (listaCoches[i].Matricula == matricula)
                {
                    return listaCoches[i];
                }
            }

            return null;
        }

        public override string ToString()
        {
            string s = "Matricula".PadRight(20) + "Marca".PadRight(20) + "Modelo".PadRight(20) + "Fecha Matr.".PadRight(20) + "Precio" + "\n";


            for (int i = 0; i < listaCoches.Count; i++)
            {
                s += listaCoches[i].Matricula.PadRight(20) + listaCoches[i].Marca.PadRight(20) + listaCoches[i].Modelo.PadRight(20) + listaCoches[i].FechaMatriculacion.ToShortDateString().PadRight(20) + listaCoches[i].Precio.ToString() + "\n";
            }

            return s;
        }
    }
}
