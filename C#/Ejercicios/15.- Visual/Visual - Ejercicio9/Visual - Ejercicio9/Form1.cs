namespace Visual___Ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbEscribe_TextChanged(object sender, EventArgs e)
        {
            lVocales.Text = NumeroVocales().ToString();
            lEspacios.Text = NumeroEspacios().ToString();
            lConsonantes.Text = (NumeroLetras() - NumeroVocales()).ToString();
            lLetras.Text = NumeroLetras().ToString();
            lPalabras.Text = NumeroPalabras().ToString();
        }


        private int NumeroPalabras()
        {
            string[] palabras = tbEscribe.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int aux, cont = 0;
            for (int i = 0; i < palabras.Length; i++)
            {
                aux = 0;
                for (int k = 0; k < palabras[i].Length; k++)
                {
                    if (char.IsLetter(palabras[i][k]))
                    {
                        aux++;
                    }
                }

                if (aux == palabras[i].Length)
                {
                    cont++;
                }
            }

            return cont;
        }
     private int NumeroLetras()
        {
            int cont = 0;
            for (int i = 0; i < tbEscribe.TextLength; i++)
            {
                if (char.IsLetter(tbEscribe.Text[i]))
                {
                    cont++;
                }
            }

            return cont;
        }
        private int NumeroVocales()
        {
            string consonantes = "qwrtypsdfghjklñzxcvbnmQWRTYPSDFGHJKLÑZXCVBNM";
            int cont = 0;

            for (int i = 0; i < tbEscribe.TextLength; i++)
            {
                if (char.IsLetter(tbEscribe.Text[i]) && !consonantes.Contains(tbEscribe.Text[i]))
                {
                    cont++;
                }
            }

            return cont;
        }

        private int NumeroEspacios()
        {
            string espacio = " ";
            int cont = 0;

            for (int i = 0; i < tbEscribe.TextLength; i++)
            {
                if (espacio.Contains(tbEscribe.Text[i]))
                {
                    cont++;
                }
            }

            return cont;
        }
    }
}