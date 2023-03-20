using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Objetos_Dinero_5_
{
    enum TipoMoneda
    {
        euro, dolar, yen, rublo
    }
    class Moneda
    {
        private TipoMoneda tMoneda;
        private int decimales;
        private string simbolo;
        private decimal cambioEuro;
        private string codigo;

        public Moneda(TipoMoneda tipoMoneda, int decimales, string simbolo, decimal cambioEuro, string codigo) {
            this.tMoneda = tipoMoneda;
            if (decimales >= 0  && decimales <= 4)
            {
                this.decimales = decimales;
            }
            else
            {
                throw new Exception("Los decimales tienen que estar entre 0 y 4");
            }
            if (simbolo != null)
            {
                this.simbolo = simbolo;
            }
            else
            {
                throw new Exception("El simbolo no puede estar vacío");
            }
            

            if (cambioEuro > 0)
            {
                this.cambioEuro = cambioEuro;
            }
            else
            {
                throw new Exception("El cambio no puede ser negativo");
            }
            this.codigo = codigo;
            }

        public int Decimales { get => decimales;}
        public string Simbolo { get => simbolo;}
        public decimal CambioEuro { get => cambioEuro;
            set {
                if (value  > 0)
                {
                    cambioEuro = value;
                }
                else
                {
                    throw new Exception("El valor no puede ser negativo");
                }
            }
        }

        public string Codigo { get => codigo;}
        internal TipoMoneda TMoneda { get => tMoneda;}
    }
}
