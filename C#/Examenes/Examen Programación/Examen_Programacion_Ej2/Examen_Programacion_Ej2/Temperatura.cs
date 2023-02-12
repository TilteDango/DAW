using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Programacion_Ej2
{
    enum UnidadTemperatura
    {
        Celsius, Farenheit, Kelvin
    }
    class Temperatura
    {
        private double valor;
        private UnidadTemperatura unidad;

        public Temperatura(double valor, UnidadTemperatura unidad)
        {
            this.valor = valor;
            this.unidad = unidad;
        }

        public double Valor { get => valor; set => valor = value; }
        public UnidadTemperatura Unidad { get => unidad; }

        public override string ToString()
        {
            string s = "";
            s += valor + " ";
            switch (unidad)
            {
                case UnidadTemperatura.Celsius: s += "°C";
                    break;
                case UnidadTemperatura.Farenheit: s += "°F";
                    break;
                case UnidadTemperatura.Kelvin: s += "K";
                    break;
                default:
                    break;
            }

            return s;
        }

        public Temperatura ConvierteEn (UnidadTemperatura unidad2)
        {
            double valor;
            if (unidad == UnidadTemperatura.Celsius)
            {
                switch (unidad2)
                {                   
                    case UnidadTemperatura.Farenheit: valor = ((this.valor * 9.0) / (5.0)) + 32;
                        break;
                    case UnidadTemperatura.Kelvin: valor = (this.valor + 273);
                        break;
                    default: valor = this.valor; break;
                }
            }
            else
            {
                if (unidad == UnidadTemperatura.Farenheit)
                {
                    switch (unidad2)
                    {
                        case UnidadTemperatura.Celsius:
                            valor = (this.valor - 32) * 5.0 / 9.0;
                            break;
                        case UnidadTemperatura.Kelvin:
                            valor = (((this.valor -32) * 5.0 / 9.0)) + 273;
                            break;
                        default:
                            valor = this.valor;
                            break;
                    }
                }
                else
                {
                    switch (unidad2)
                    {
                        case UnidadTemperatura.Celsius: valor = this.valor - 273;
                            break;
                        case UnidadTemperatura.Farenheit: valor = ((this.valor - 273) * 9 / 5) + 32;
                            break;
                       
                        default: valor = this.valor;
                            break;
                    }
                }
            }

            return new Temperatura(valor, unidad2);

           
        }

        public static bool operator ==(Temperatura t1, Temperatura t2)
        {
            bool igual = false;
            if (t1.Unidad == t2.Unidad)
            {
                if (t1.Valor == t2.Valor)
                {
                    igual = true;
                }
            }
            else
            {
                t2 = t2.ConvierteEn(t1.Unidad);

                if (t1.Valor == t2.Valor)
                {
                    igual = true;
                }
            }

            return igual;
        }

        public static bool operator != (Temperatura t1, Temperatura t2)
        {
            return !(t1 == t2);
        }

        public static bool operator <(Temperatura t1, Temperatura t2)
        {
            bool igual = false;
            if (t1.Unidad == t2.Unidad)
            {
                if (t1.Valor < t2.Valor)
                {
                    igual = true;
                }
            }
            else
            {
                t2 = t2.ConvierteEn(t1.Unidad);

                if (t1.Valor < t2.Valor)
                {
                    igual = true;
                }
            }

            return igual;
        }

        public static bool operator >(Temperatura t1, Temperatura t2)
        {
            bool igual = false;
            if (t1.Unidad == t2.Unidad)
            {
                if (t1.Valor > t2.Valor)
                {
                    igual = true;
                }
            }
            else
            {
                t2 = t2.ConvierteEn(t1.Unidad);

                if (t1.Valor > t2.Valor)
                {
                    igual = true;
                }
            }

            return igual;
        }

        public static bool operator >= (Temperatura t1, Temperatura t2)
        {
            return (t1 > t2 || t1 == t2);
        }

        public static bool operator <= (Temperatura t1, Temperatura t2)
        {
            return (t1 < t2 || t1 == t2);
        }
    }
}
