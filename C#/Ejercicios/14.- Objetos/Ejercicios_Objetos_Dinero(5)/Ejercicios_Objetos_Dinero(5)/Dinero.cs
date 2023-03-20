using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Ejercicios_Objetos_Dinero_5_
{
    class Dinero
    {
        private static List<Moneda> listaMonedas = new List<Moneda>();

        static Dinero()
        {
            listaMonedas.Add(new Moneda(TipoMoneda.euro, 2, "€", 1, "EUR"));
            listaMonedas.Add(new Moneda(TipoMoneda.dolar, 2, "$", 1.084749m, "USD"));
            listaMonedas.Add(new Moneda(TipoMoneda.yen, 0, "¥", 126.132m, "JPY"));
            listaMonedas.Add(new Moneda(TipoMoneda.rublo, 2, "₽", 148.85604m,"RUB"));
        }

        public static void ActualizaCambio(TipoMoneda tmoneda, decimal cambio)
        {
            for (int i = 0; i < listaMonedas.Count; i++)
            {
                if (listaMonedas[i].TMoneda == tmoneda)
                {
                    listaMonedas[i].CambioEuro = cambio;
                    i = listaMonedas.Count;
                }
            }
        }

        public static Moneda BuscaMoneda(TipoMoneda t)
        {
            for (int i = 0; i < listaMonedas.Count; i++)
            {
                if (listaMonedas[i].TMoneda == t)
                {
                    return listaMonedas[i];
                }
            }

            return null;
        }

        private decimal cantidad;
        private TipoMoneda tMoneda;

        public decimal Cantidad { get => cantidad; set => cantidad = value; }
        internal TipoMoneda TMoneda { get => tMoneda; set => tMoneda = value; }

        public Dinero(decimal cantidad, TipoMoneda t)
        {
            this.cantidad = cantidad;
            this.tMoneda = t;
        }

        public Dinero(int cantidad, TipoMoneda t)
        {
            this.cantidad = cantidad;
            this.tMoneda = t;
        }

        public Dinero(double cantidad, TipoMoneda t)
        {
            this.cantidad = (decimal)cantidad;
            this.tMoneda = t;
        }

        public override string ToString()
        {
            decimal d = Math.Round(cantidad, BuscaMoneda(tMoneda).Decimales);

            return d + BuscaMoneda(TMoneda).Simbolo;
        }

        public decimal ValorEn(TipoMoneda t)
        {
            decimal can;
            if (tMoneda != TipoMoneda.euro)
            {
                Moneda m = BuscaMoneda(tMoneda);
                can = cantidad / m.CambioEuro;
            }
            else
            {
                can = cantidad;
            }

            if (t != TipoMoneda.euro)
            {
                can = can * BuscaMoneda(t).CambioEuro;
            }

            return can;
            
        }

        public Dinero ConvierteEn(TipoMoneda t)
        {
            return new Dinero(ValorEn(t), t);
        }

        public string ToString(TipoMoneda t)
        {
            return ConvierteEn(t).ToString();
        }

        public static Dinero operator +(Dinero d1, Dinero d2)
        {
            Dinero d3 = d2.ConvierteEn(d1.tMoneda);
            return new Dinero((d3.Cantidad + d1.Cantidad), d3.tMoneda);
        }

        public static Dinero operator -(Dinero d1, Dinero d2)
        {
            Dinero d3 = d2.ConvierteEn(d1.tMoneda);
            return new Dinero((d3.Cantidad - d1.Cantidad), d3.tMoneda);
        }

        public static Dinero operator *(Dinero d1, decimal d2)
        {
            return new Dinero((d1.Cantidad * d2), d1.tMoneda);
        }
        public static Dinero operator /(Dinero d1, decimal d2)
        {
            return new Dinero((d1.cantidad / d2), d1.TMoneda);
        }

        public static Dinero operator -(Dinero d)
        {
            return new Dinero(-d.Cantidad, d.TMoneda);
        }

        public static bool operator ==(Dinero d1, Dinero d2)
        {
            Dinero d3 = d2.ConvierteEn(d1.tMoneda);

            return d3.Cantidad == d1.Cantidad;
        }

        public static bool operator !=(Dinero d1, Dinero d2)
        {
            return !(d1 == d2);
        }

        public static bool operator >(Dinero d1, Dinero d2)
        {
            Dinero d3 = d2.ConvierteEn(d1.tMoneda);
            return d1.Cantidad > d3.Cantidad;
        }

        public static bool operator <(Dinero d1, Dinero d2)
        {
          
            return !(d1.Cantidad > d2.Cantidad);
        }

        public static bool operator >=(Dinero d1, Dinero d2)
        {
            return (d1.Cantidad > d2.Cantidad) || (d1.Cantidad == d2.Cantidad);
        }

        public static bool operator <=(Dinero d1, Dinero d2)
        {
            return (d1 < d2) || (d1 == d2);
        }

        public static void ActualizaListaInternet()
        {
            WebClient wc = new WebClient();
            string pagina = wc.DownloadString("https://api.exchangerate.host/base=EUR");
            int n;
            bool escribe = false;
            for (int i = 1; i < listaMonedas.Count; i++)
            {
                string precio = "";

                n = pagina.IndexOf(listaMonedas[i].Codigo);
                    
                 
                for (int k = n; k < pagina.Length; k++)
                {
                    if (pagina[k] == ':')
                    {
                        escribe = true;
                    }
                    else
                    {

                        if (escribe)
                        {
                            if (pagina[k] == ',')
                            {
                                escribe = false;
                                listaMonedas[i].CambioEuro = decimal.Parse(precio.Replace('.',','));
                                k = pagina.Length;
                            }
                            else
                            {
                                precio += pagina[k];
                            }
                        }
                    }
                }
            }
            
          

        }
    }
}
