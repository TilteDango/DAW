using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Programacion_Ej4
{
    public class SmartArray
    {
        private int[] array;

        public SmartArray(int size)
        {
            array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }

        public int Length
        {
            get
            {
                return array.Length;
            }
        }

        public override string ToString()
        {
            string s = "[";

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    s += array[i];
                }
                else
                {
                    s += array[i] + ", ";
                }               
            }
            s += "]";
            return s;
        }

        public bool Contains (int value)
        {
            bool esta = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    esta = true;
                }
            }

            return esta;
        }

        public int IndexOf(int value)
        {
            int pos = 0;
            if (!array.Contains(value))
            {
                pos = -1;
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == value)
                    {
                        pos = i;
                    }
                }
            }

            return pos;
        }

        public void Sort()
        {
            List<int> l = new List<int>();

            l.AddRange(array);
            l.Sort();

            for (int i = 0; i < l.Count; i++)
            {
                array[i] = l[i];
            }
        }

        public void Reverse()
        {
            List<int> l = new List<int>();

            l.AddRange(array);
            l.Reverse();

            for (int i = 0; i < l.Count; i++)
            {
                array[i] = l[i];
            }
        }

        public void Shuffle()
        {
            List<int> l = new List<int>();
            int n;
            Random r = new Random();
            l.AddRange(array);
            int i = 0;
             while (l.Count > 0)
            {
               n = r.Next(l.Count);
                array[i] = l[n];
                l.RemoveAt(n);
                i ++;
            }
        }

        public static bool operator ==(SmartArray a, SmartArray b)
        {
            bool cierto = false;
            int cont = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    cont++;
                }
            }

            if (cont == a.Length)
            {
                cierto = true;
            }

            return cierto;
        }

        public static bool operator !=(SmartArray a, SmartArray b)
        {
            return !(a == b);
        }
    }
}
