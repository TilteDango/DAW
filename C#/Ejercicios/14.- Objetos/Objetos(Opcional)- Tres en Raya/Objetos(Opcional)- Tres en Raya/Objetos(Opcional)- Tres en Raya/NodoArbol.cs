using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_Opcional___Tres_en_Raya
{
    class NodoArbol
    {
        public int[] datos;
        public int nivel;
        public int puntuacion = -1000;
        public List<NodoArbol> hijos;

        public NodoArbol(int[] datos, int nivel)
        {
            this.datos = datos;
            this.nivel = nivel;
            this.hijos = new List<NodoArbol>();
        }

        public void InsertaHijo(NodoArbol n)
        {
            this.hijos.Add(n);
        }

        //public void CreaPadreNodo()
        //{
        //    for (int i = 0; i < 9; i++)
        //    {
        //        int[] tablero = (int[])datos.Clone();
        //        tablero[i] = 1;
        //        NodoArbol hijo = new NodoArbol(tablero);
        //        hijos.Add(hijo);
        //    }
        //}

        public void CreaNodoHijo()
        {

            if (TresEnRaya.QuedanMovimientos(datos) && !TresEnRaya.GanaJugador(datos, 1) && !TresEnRaya.GanaJugador(datos, 2))
            {
                for (int i = 0; i < 9; i++)
                {
                    int[] tablero = (int[])datos.Clone();

                    if (tablero[i] == 0)
                    {
                        if (this.nivel % 2 == 0)
                        {
                            tablero[i] = 1;
                        }
                        else
                        {
                            tablero[i] = 2;
                        }
                        NodoArbol hijo = new NodoArbol(tablero, this.nivel + 1);
                        hijos.Add(hijo);
                        hijo.CreaNodoHijo();
                    }
                }
            }
        }

        public int Puntuacion2()
        {
            // El ordenador es el 2
            if (hijos.Count == 0)
            {
                if (TresEnRaya.GanaJugador(datos, 1))
                {
                    puntuacion = -1;
                }
                else if (TresEnRaya.GanaJugador(datos, 2))
                {
                    puntuacion = 1;
                }
                else
                {
                    puntuacion = 0;
                }
            }
            else
            {
                if (nivel % 2 == 0)
                {
                    int min = 1000;
                    for (int i = 0; i < hijos.Count; i++)
                    {
                        int punt = hijos[i].Puntuacion2();

                        if (punt < min)
                        {
                            min = punt;
                        }
                    }
                    puntuacion = min ;
                }
                else
                {
                    int max = -1000;
                    for (int i = 0; i < hijos.Count; i++)
                    {
                        int punt = hijos[i].Puntuacion2();
                        if (punt > max)
                        {
                            max = punt;
                        }
                    }
                    puntuacion = max;
                }
            }

            return puntuacion;
        }

        public void Imprime()
        {
            Console.WriteLine(EscribeArray(datos));
            for (int i = 0; i < hijos.Count; i++)
            {
                
                hijos[i].Imprime();
            }
        }

        public static string EscribeArray(int[] a)
        {
            string cad = "[ ";

            for (int i = 0; i < a.Length; i++)
            {
                cad = cad + a[i] + ", ";
            }

            cad = cad + "]";

            return cad;
        }

        
    }

}
