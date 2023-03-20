using System;
using System.Collections.Generic;
using System.Text;

namespace Clases_1__Carta_y_Baraja
{
    enum Palo
    {
        Oros, Copas, Espadas, Bastos
    }
    class Carta
    {
        private int numero;
        private Palo palo;



        public Carta(int numero, Palo palo)
        {
            if (numero > 0 && numero <= 12 && numero != 8 && numero != 9)
            {
                this.numero = numero;
            }
            else
            {
                throw new Exception("Ese número de carta no es válido");
            }

            this.palo = palo;
        }
        public Carta(int id)
        {
            int n;
            if (id < 1 || id > 40)
            {
                throw new Exception("Ese número de carta no es válido");
            }
            else
            {
                n = (id - 1) / 10;
                switch (n)
                {
                    case 0: palo = Palo.Oros; break;
                    case 1: palo = Palo.Copas; break;
                    case 2: palo = Palo.Espadas; break;
                    case 3: palo = Palo.Bastos; break;
                }

                n = id % 10;

                switch (n)
                {
                    case 8: n = n + 2; break;
                    case 9: n = n + 2; break;
                    case 0: n = n + 12; break;
                }

                numero = n;
            }
        }

        public int Numero { get => numero; }
        public Palo PaloCarta { get => palo; }
        private string NombreNumero
        {
            get
            {
                string s ="";
                switch (numero)
                {
                    case 1: s= "As"; break;
                    case 2: s = "Dos"; break;
                    case 3: s = "Tres"; break;
                    case 4: s = "Cuatro"; break;
                    case 5: s = "Cinco"; break;
                    case 6: s = "Seis"; break;
                    case 7: s = "Siete"; break;
                    case 10: s = "Sota"; break;
                    case 11: s = "Caballo"; break;
                    case 12: s = "Rey"; break;
                }
                return s;
            }
        }

        private string NombrePalo
        {
            get
            {
                string s = "";
                switch (palo)
                {
                    case Palo.Oros: s = "oros";
                        break;
                    case Palo.Copas: s = "copas";
                        break;
                    case Palo.Espadas: s = "espadas";
                        break;
                    case Palo.Bastos: s = "bastos";
                        break;                    
                }
                return s;
            }
        }

        public string NombreCarta
        {
            get
            {
                string s;
                s = NombreNumero + " de " + NombrePalo;
                return s;
            }
        }

        public int ValorTute
        {
            get
            {
                int n;
                switch (numero)
                {
                    case 1: n = 11; break;
                    case 3: n = 10;break;
                    case 10: n = 2; break;
                    case 11: n = 3; break;
                    case 12: n = 4; break;
                    default: n = 0; break;
                }
                return n;
            }
        }

        public int ValorMus
        {
            get
            {
                int n;
                switch (numero)
                {
                    case 1: n = 1; break;
                    case 2: n = 1; break;
                    case 3: n = 10; break;
                    case 10: n = 10; break;
                    case 11: n = 10; break;
                    case 12: n = 10; break;
                    default: n = numero; break;
                }
                return n;
            }
        }

        public decimal Valor7ymedia
        {
            get
            {
                decimal n = 0.0m;
                switch (numero)
                {
                    case 10: n = 0.5m; break;
                    case 11: n = 0.5m; break;
                    case 12: n = 0.5m; break;
                    default: n = numero; break;                       
                }

                return n;
            }
        }

        public override string ToString()
        {
            return NombreCarta;
        }



    }
}
