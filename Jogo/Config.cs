using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Jogo
{
    class Mapa
    {
        public static string[,] mapa = new string[20, 20]
            {
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"},
                {"O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O","O"}
            };

    }
    class Config
    {

        public static string MovimentoHorizontalMonstros()
        {
            Random rnd = new Random();
            string direcao;
            string[] sentidos = { "direita", "esquerda" };
            int indice = rnd.Next(sentidos.Length);
            direcao = sentidos[indice];

            return direcao;
        }

        public static string MovimentoVerticalMonstros()
        {
            Random rnd = new Random();
            string direcao;
            string[] sentidos = { "cima", "baixo" };
            int indice = rnd.Next(sentidos.Length);
            direcao = sentidos[indice];

            return direcao;
        }

        public static string NascimentoMonstros()
        {
            Random rnd = new Random();

            int[] horizontal = { 2, 17 };
            int[] vertical = { 2, 17 };
            int indicehorizontal = rnd.Next(horizontal.Length);
            int indicevertical = rnd.Next(vertical.Length);
            int posicaohorizontal = horizontal[indicehorizontal];
            int posicaovertical = vertical[indicevertical];



            return Mapa.mapa[posicaohorizontal,posicaovertical]=Monstro.valor;
        }


        public static string MovimentoHeroi()
        {
            
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (Mapa.mapa[i, j] == "H")
                    {
                        int cimabaixo = i;
                        int esqdir = j;
                        
                        ConsoleKeyInfo movimento = Console.ReadKey();
                        if (movimento.Key == ConsoleKey.A)
                        {
                            if (esqdir <= 0)
                            {
                                return Mapa.mapa[cimabaixo, esqdir] = Heroi.valor;
                            }
                            else
                            {
                                Mapa.mapa[cimabaixo, esqdir] = "O";

                                return Mapa.mapa[cimabaixo, esqdir - 1] = Heroi.valor;
                            }

                        }

                        else if (movimento.Key == ConsoleKey.D)
                        {
                            if (esqdir >= 19)
                            {
                                return Mapa.mapa[cimabaixo, esqdir] = Heroi.valor;
                            }
                            else
                            {
                                Mapa.mapa[cimabaixo, esqdir] = "O";

                                return Mapa.mapa[cimabaixo, esqdir + 1] = Heroi.valor;
                            }

                        }
                        else if (movimento.Key == ConsoleKey.S)
                        {
                            if (cimabaixo >= 19)
                            {
                                return Mapa.mapa[cimabaixo, esqdir] = Heroi.valor;
                            }
                            else
                            {
                                Mapa.mapa[cimabaixo, esqdir] = "O";

                                return Mapa.mapa[cimabaixo+1, esqdir] = Heroi.valor;
                            }

                        }

                        else if (movimento.Key == ConsoleKey.W)
                        {
                            if (cimabaixo <= 0)
                            {
                                return Mapa.mapa[cimabaixo, esqdir] = Heroi.valor;
                            }
                            else
                            {
                                Mapa.mapa[cimabaixo, esqdir] = "O";

                                return Mapa.mapa[cimabaixo -1, esqdir] = Heroi.valor;
                            }

                        }

                        else
                        {
                            return Mapa.mapa[esqdir, cimabaixo] = Heroi.valor;
                        }



                    }
                }
                
             
            }



            
            return Mapa.mapa[0,0] = Heroi.valor;
        }
    }
}