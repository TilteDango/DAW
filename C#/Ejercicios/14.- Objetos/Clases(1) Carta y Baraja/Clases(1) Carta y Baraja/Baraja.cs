using System;
using System.Collections.Generic;
using System.Text;

namespace Clases_1__Carta_y_Baraja
{
    class Baraja
    {
        private List<Carta> listaCartas;

        public Baraja()
        {
            this.listaCartas = new List<Carta>();
        }

        public Baraja(bool barajar)
        {
            this.listaCartas = new List<Carta>();
            for (int i = 1; i <= 40; i++)
            {
                Carta c = new Carta(i);
                listaCartas.Add(c);
            }

            if (barajar)
            {
                Barajar();
            }
        }

        public void Barajar()
        {
            int n;
            Random r = new Random();
            List<Carta> aux = new List<Carta>();
            while (listaCartas.Count != 0)
            {
                n = r.Next(listaCartas.Count);
                aux.Add(listaCartas[n]);
                listaCartas.RemoveAt(n);
            }

            listaCartas.AddRange(aux);


        }

        public void Cortar(int n)
        {
            List<Carta> aux = new List<Carta>();

            for (int i = n; i < listaCartas.Count; i++)
            {
                aux.Add(listaCartas[i]);
            }

            for (int i = 0; i < n; i++)
            {
                aux.Add(listaCartas[i]);
            }

            listaCartas.Clear();
            listaCartas.AddRange(aux);
        }

        public Carta Robar()
        {
            if (listaCartas.Count > 0)
            {
                Carta c = listaCartas[0];
                listaCartas.RemoveAt(0);
                return c;
            }
            else
            {
                throw new Exception("No quedan cartas que robar");
            }



        }

        public void InsertaCartaFinal(int idCarta)
        {
            Carta c = new Carta(idCarta);
            listaCartas.Add(c);
        }

        public void InsertaCartaPrincipio(int idCarta)
        {
            Carta c = new Carta(idCarta);

            listaCartas.Insert(0, c);
        }

        public void InsertaCartaFinal(Carta c)
        {
            listaCartas.Add(c);
        }

        public void InsertaCartaPrincipio(Carta c)
        {
            listaCartas.Insert(0, c);
        }

        public int NumeroCartas
        {
            get
            {
                return listaCartas.Count;
            }
        }

        public bool Vacia
        {
            get
            {
                if (listaCartas.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
