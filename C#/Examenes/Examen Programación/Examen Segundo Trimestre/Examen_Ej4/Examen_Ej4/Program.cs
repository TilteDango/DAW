using System;

namespace Examen_Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tableroAjedrez = { { 0, 0, 0, 0, 0, 1, 0, 0 },
                          { 0, 0, 0, 1, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 0, 0, 1, 0 },
                          { 1, 0, 0, 0, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 0, 0, 0, 1 },
                          { 0, 1, 0, 0, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 0, 1, 0, 0 },
                          { 0, 0, 1, 0, 0, 0, 0, 0 } };
            Console.WriteLine(CompruebaDamas(tableroAjedrez));
        }

        static bool CompruebaDamas (int[,] tablero)
        {
            int cont = 1;
            bool ataca = false;
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if (tablero[x,y] != 0)
                    {
                        //Calcula horizontal
                        for (int j = 0; j < y; j++)
                        {
                            if (tablero[x,j] != 0)
                            {
                                ataca = true;
                            }
                        }
                        for (int j = y +1; j < 8; j++)
                        {
                            if (tablero[x,j] != 0)
                            {
                                ataca = true;
                            }
                        }
                        //Calcula vertical
                        for (int j = 0; j < x; j++)
                        {
                            if (tablero[j, y] != 0)
                            {
                                ataca = true;
                            }
                             
                        }
                        for (int j = x +1; j < 8; j++)
                        {
                            if (tablero[j,y] != 0)
                            {
                                ataca = true;
                            }
                        }
                        //Calcular diagonal
                        cont = 1;
                        while (x + cont < 8 && y + cont < 8)
                        {
                            if (tablero[x+cont, y+cont] != 0)
                            {
                                ataca = true;
                            }
                            cont++;
                        }
                        cont = 1;

                        while (x + cont < 8 && y - cont > 0)
                        {
                            if (tablero[x+cont, y-cont] != 0)
                            {
                                ataca = true;
                            }
                            cont++;
                        }
                        cont = 1;
                        while (x - cont > 0 && y - cont > 0)
                        {
                            if (tablero[x-cont,y-cont] != 0)
                            {
                                ataca = true;
                            }
                            cont++;
                        }
                        cont = 1;
                        while (x - cont > 0 && y + cont < 8)
                        {
                            if (tablero[x-cont,y+cont] != 0)
                            {
                                ataca = true;
                            }
                            cont++;
                        }

                    }

                    
                }
            }
            return ataca;
        }

        
    }
}
