using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_4____Fracciones
{
    class Fraccion
    {
        //Explicacion Operadores
        //public static Fraccion operator +(Fraccion c1, Fraccion c2)
        //{
        //    Fraccion hola = new Fraccion();
        //    return hola;
        //}


        private int numerador;
        private int denominador;

        public int Numerador { get => numerador; set => numerador = value; }
        public int Denominador
        {
            get => denominador; set
            {
                if (denominador != 0)
                {
                    this.denominador = value;
                }
                else
                {
                    throw new Exception("El denominador no puede ser 0");
                }
            }
        }
        public Fraccion(int numerador, int denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;


        }

        public Fraccion(int numerador)
        {
            this.numerador = numerador;
            this.denominador = 1;
        }

        public Fraccion(double n)
        {
            int denominador = 0;
            while (Math.Truncate(n) != n)
            {
                n = n * 10;
                denominador = denominador * 10;

            }

            this.numerador = (int)n;
            this.denominador = denominador;
        }

        private static int MCD(int n1, int n2)
        {

            while (n1 != n2)
            {
                if (n1 > n2)
                {
                    n1 = n1 - n2;
                }
                else
                {
                    n2 = n2 - n1;
                }
            }
            return n1;
        }

        private static int MCM(int n, int n2)
        {
            int mcm;
            mcm = (n * n2) / MCD(n, n2);

            return mcm;
        }

        public void Simplificar()
        {
            int n = MCD(this.numerador, this.denominador);

            this.numerador = this.numerador / n;
            this.denominador = this.denominador / n;
        }

        public override string ToString()
        {
            string cad = "";

            cad = this.numerador + "/" + this.denominador;
            return cad;
        }

        public static Fraccion operator -(Fraccion f)
        {
            return new Fraccion(-f.numerador, f.denominador);
        }

        public static Fraccion operator +(Fraccion f1, Fraccion f2)
        {
            Fraccion f4 = new Fraccion(f1.numerador, f2.denominador);
            Fraccion f5 = new Fraccion(f1.numerador, f2.denominador);
            int n, num1, num2;
            if (f1.denominador != f2.denominador)
            {
                n = MCM(f1.denominador, f2.denominador);
                num1 = n / f1.denominador;
                num2 = n / f2.denominador;

                f4.numerador =f1.numerador * num1;
                f5.numerador = f2.numerador * num2;
                f4.denominador = n;
                f5.denominador = n;
            }

            Fraccion f3 = new Fraccion((f4.numerador + f5.numerador), f5.denominador);

            //Fraccion f3 = new Fraccion((f1.numerador * f2.denominador + f2.numerador * f1.denominador), f1.denominador * f2.denominador);
            //f3.Simplificar();
            return f3;
        }

        public static Fraccion operator -(Fraccion f1, Fraccion f2)
        {
            return f1 + (-f2);
        }

        public static Fraccion operator *(Fraccion f1, Fraccion f2)
        {
            return new Fraccion((f1.numerador * f2.numerador), (f1.denominador * f2.denominador));
        }

        public static Fraccion operator /(Fraccion f1, Fraccion f2)
        {
            return new Fraccion((f1.numerador * f2.denominador), (f1.denominador * f2.numerador));
        }

        public static bool operator ==(Fraccion f1, Fraccion f2)
        {
            return f1.numerador * f2.denominador == f1.denominador * f2.numerador;
        }

        public static bool operator !=(Fraccion f1, Fraccion f2)
        {
            return !(f1 == f2);
        }

        public static bool operator >(Fraccion f1, Fraccion f2)
        {
            return (f1.numerador * f2.denominador) > (f1.denominador * f2.numerador);
        }

        public static bool operator <(Fraccion f1, Fraccion f2)
        {
            return !(f1 > f2);
        }

        public static bool operator >=(Fraccion f1, Fraccion f2)
        {
            return f1 == f2 || f1 > f2;
        }

        public static bool operator <=(Fraccion f1, Fraccion f2)
        {
            return f1 == f2 || f1 < f2;
        }

        public static implicit operator Fraccion(int n){
            return new Fraccion(n);
            }
        public static implicit operator Fraccion(double n)
        {
            return new Fraccion(n);
        }
      
    }
}
