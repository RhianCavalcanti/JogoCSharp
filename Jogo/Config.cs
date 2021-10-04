using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Jogo;

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
        public static Boolean clickEscape()
        {
            return false;
        }

        //public static string MovimentoHorizontalMonstros()
        //{
        //    Random rnd = new Random();
        //    string direcao;
        //    string[] sentidos = { "direita", "esquerda" };
        //    int indice = rnd.Next(sentidos.Length);
        //    direcao = sentidos[indice];

        //    return direcao;
        //}

        //public static string MovimentoVerticalMonstros()
        //{
        //    Random rnd = new Random();
        //    string direcao;
        //    string[] sentidos = { "cima", "baixo" };
        //    int indice = rnd.Next(sentidos.Length);
        //    direcao = sentidos[indice];

        //    return direcao;
        //}

        public static bool NascimentoMonstros()
        {
            //int qntdMonstros = 0;
            int[] horizontal = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            int[] vertical = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            Random rnd = new Random();


            int indicehorizontal = rnd.Next(horizontal.Length);
            int indicevertical = rnd.Next(vertical.Length);
            int posicaohorizontal = horizontal[indicehorizontal];
            int posicaovertical = vertical[indicevertical];
            if (Mapa.mapa[posicaovertical, posicaohorizontal] == "O" & Mapa.mapa[posicaovertical, posicaohorizontal] != Monstro.getValor())
            {
                Mapa.mapa[posicaovertical, posicaohorizontal] = Monstro.getValor();
            }
            /*while (qntdMonstros <7)
            {
                
                int indicehorizontal = rnd.Next(horizontal.Length);
                int indicevertical = rnd.Next(vertical.Length);
                int posicaohorizontal = horizontal[indicehorizontal];
                int posicaovertical = vertical[indicevertical];
                if (Mapa.mapa[posicaovertical, posicaohorizontal] == "O" & Mapa.mapa[posicaovertical, posicaohorizontal] != Monstro.getValor())
                {

                    qntdMonstros = qntdMonstros + 1;
                    Mapa.mapa[posicaovertical, posicaohorizontal] = Monstro.getValor();
                }

            }*/
            return true;
        }

        public static bool Pocoes()
        {
            int qtdPocoes = 0;
            int[] horizontal = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            int[] vertical = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            Random rnd = new Random();
            while (qtdPocoes < 9)
            {

                int indicehorizontal = rnd.Next(horizontal.Length);
                int indicevertical = rnd.Next(vertical.Length);
                int posicaohorizontal = horizontal[indicehorizontal];
                int posicaovertical = vertical[indicevertical];
                if (Mapa.mapa[posicaohorizontal, posicaovertical] == "O" && Mapa.mapa[posicaohorizontal, posicaovertical] != Monstro.getValor())
                {

                    qtdPocoes = qtdPocoes + 1;
                    Mapa.mapa[posicaohorizontal, posicaovertical] = "P";
                }

            }
            return true;
        }

        public static string MovimentoHeroi()
        {
            Heroi hero = new Heroi();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (Mapa.mapa[i, j] == "H")
                    {
                        int cimabaixo = i;
                        int esqdir = j;
                        
                        ConsoleKeyInfo movimento = Console.ReadKey();
                        switch (movimento.Key)
                        {
                            case ConsoleKey.A:
                                hero.contaScore();
                                if (esqdir <= 0)
                                {
                                    hero.reduzVida();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo, esqdir - 1] == Monstro.getValor())
                                {
                                    hero.reduzVida();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo, esqdir - 1] == "P")
                                {
                                    hero.bebePocao();
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    return Mapa.mapa[cimabaixo, esqdir - 1] = hero.getValor();
                                }
                                else
                                {
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    hero.reduzVida();
                                    return Mapa.mapa[cimabaixo, esqdir - 1] = hero.getValor();
                                }
                                break;

                            case ConsoleKey.D:
                                hero.contaScore();
                                if (esqdir >= 19)
                                {
                                    hero.reduzVida();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo, esqdir + 1] == Monstro.getValor())
                                {
                                    hero.reduzVida();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo, esqdir + 1] == "P")
                                {
                                    hero.bebePocao();
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    return Mapa.mapa[cimabaixo, esqdir + 1] = hero.getValor();
                                }
                                else
                                {
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    hero.reduzVida();
                                    return Mapa.mapa[cimabaixo, esqdir + 1] = hero.getValor();
                                }
                                break;
                            case ConsoleKey.S:
                                hero.contaScore();
                                if (cimabaixo >= 19)
                                {
                                    hero.reduzVida();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo + 1, esqdir] == Monstro.getValor())
                                {
                                    hero.reduzVida();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo + 1, esqdir] == "P")
                                {
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    hero.bebePocao();
                                    return Mapa.mapa[cimabaixo + 1, esqdir] = hero.getValor();
                                }
                                else
                                {
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    hero.reduzVida();
                                    return Mapa.mapa[cimabaixo + 1, esqdir] = hero.getValor();
                                }
                                break;
                            case ConsoleKey.W:
                                hero.contaScore();
                                if (cimabaixo <= 0)
                                {
                                    hero.reduzVida();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo - 1, esqdir] == Monstro.getValor())
                                {
                                    hero.reduzVida();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo - 1, esqdir] == "P")
                                {
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    hero.bebePocao();
                                    return Mapa.mapa[cimabaixo - 1, esqdir] = hero.getValor();
                                }
                                else
                                {
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    hero.reduzVida();
                                    return Mapa.mapa[cimabaixo - 1, esqdir] = hero.getValor();
                                }
                                break;
                            case ConsoleKey.Escape:
                                Environment.Exit(0);
                                break;
                            default:
                                break;
                        }
                        //if (movimento.Key == ConsoleKey.A)
                        //{
                        //    hero.contaScore();
                        //    if (esqdir <= 0)
                        //    {
                        //        hero.reduzVida();
                        //        return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                        //    }
                        //    else if (Mapa.mapa[cimabaixo, esqdir-1] == Monstro.getValor())
                        //    {
                        //        hero.reduzVida();
                        //        return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                        //    }
                        //    else if (Mapa.mapa[cimabaixo, esqdir - 1] == "P")
                        //    {
                        //        hero.bebePocao();
                        //        Mapa.mapa[cimabaixo, esqdir] = "O";
                        //        return Mapa.mapa[cimabaixo, esqdir -1] = hero.getValor();
                        //    }
                        //    else
                        //    {
                        //        Mapa.mapa[cimabaixo, esqdir] = "O";
                        //        hero.reduzVida();
                        //        return Mapa.mapa[cimabaixo, esqdir - 1] = hero.getValor();
                        //    }
                            
                        //}

                        //else if (movimento.Key == ConsoleKey.D)
                        //{
                        //    hero.contaScore();
                        //    if (esqdir >= 19)
                        //    {
                        //        hero.reduzVida();
                        //        return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                        //    }
                        //    else if (Mapa.mapa[cimabaixo, esqdir+1] == Monstro.getValor())
                        //    {
                        //        hero.reduzVida();
                        //        return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                        //    }
                        //    else if (Mapa.mapa[cimabaixo, esqdir + 1] == "P")
                        //    {
                        //        hero.bebePocao();
                        //        Mapa.mapa[cimabaixo, esqdir] = "O";
                        //        return Mapa.mapa[cimabaixo, esqdir + 1] = hero.getValor();
                        //    }
                        //    else
                        //    {
                        //        Mapa.mapa[cimabaixo, esqdir] = "O";
                        //        hero.reduzVida();
                        //        return Mapa.mapa[cimabaixo, esqdir + 1] = hero.getValor();
                        //    }

                        //}
                        //else if (movimento.Key == ConsoleKey.S)
                        //{
                        //    hero.contaScore();
                        //    if (cimabaixo >= 19)
                        //    {
                        //        hero.reduzVida();
                        //        return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                        //    }
                        //    else if (Mapa.mapa[cimabaixo+1, esqdir] == Monstro.getValor())
                        //    {
                        //        hero.reduzVida();
                        //        return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                        //    }
                        //    else if (Mapa.mapa[cimabaixo + 1, esqdir] == "P")
                        //    {
                        //        Mapa.mapa[cimabaixo, esqdir] = "O";
                        //        hero.bebePocao();
                        //        return Mapa.mapa[cimabaixo + 1, esqdir] = hero.getValor();
                        //    }
                        //    else
                        //    {
                        //        Mapa.mapa[cimabaixo, esqdir] = "O";
                        //        hero.reduzVida();
                        //        return Mapa.mapa[cimabaixo+1, esqdir] = hero.getValor();
                        //    }

                        //}

                        //else if (movimento.Key == ConsoleKey.W)
                        //{
                        //    hero.contaScore();
                        //    if (cimabaixo <= 0)
                        //    {
                        //        hero.reduzVida();
                        //        return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                        //    }
                        //    else if (Mapa.mapa[cimabaixo-1, esqdir] == Monstro.getValor())
                        //    {
                        //        hero.reduzVida();
                        //        return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                        //    }
                        //    else if (Mapa.mapa[cimabaixo - 1, esqdir] == "P")
                        //    {
                        //        Mapa.mapa[cimabaixo, esqdir] = "O";
                        //        hero.bebePocao();
                        //        return Mapa.mapa[cimabaixo - 1, esqdir] = hero.getValor();
                        //    }
                        //    else
                        //    {
                        //        Mapa.mapa[cimabaixo, esqdir] = "O";
                        //        hero.reduzVida();
                        //        return Mapa.mapa[cimabaixo -1, esqdir] = hero.getValor();
                        //    }

                        //}

                         /*else if (movimento.Key == ConsoleKey.Spacebar)  //checar se tem monstro para causar dano
                         {
                             if (cimabaixo <= 0)
                             {
                                 hero.reduzVida();
                                 return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                             }
                             else if (Mapa.mapa[cimabaixo - 1, esqdir] == Monstro.getValor())
                             {
                                 hero.reduzVida();
                                 return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                             }
                             else
                             {
                                 Mapa.mapa[cimabaixo, esqdir] = "O";
                                 hero.reduzVida();
                                 return Mapa.mapa[cimabaixo - 1, esqdir] = hero.getValor();
                             }

                         }*/

                        //else if (movimento.Key == ConsoleKey.Escape) //se clicar em Esc
                        //{
                        //    Environment.Exit(0);
                        //}
                        
                        //else
                        //{
                        //    return Mapa.mapa[esqdir, cimabaixo] = hero.getValor();
                        //}



                    }
                }
                
             
            }



            
            return "none";
        }
        //public static string MovimentoMonstros()
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        for (int j = 0; j < 20; j++)
        //        {
                    
        //            int monstrodiresq = j;
        //            int monstrocimabaixo = i;
        //            if (Mapa.mapa[i, j] == Monstro.getValor())  //aqui ele só movimenta o primeiro monstro que acha no mapa
        //            {   
                      
        //                if (MovimentoHorizontalMonstros() == "esquerda" & j> 2 & Mapa.mapa[monstrocimabaixo, monstrodiresq-1]=="O")
        //                {
        //                    Mapa.mapa[monstrocimabaixo, monstrodiresq] = "O";
        //                    return Mapa.mapa[monstrocimabaixo, monstrodiresq - 1] = Monstro.getValor();
        //                }
        //                else if (MovimentoHorizontalMonstros() == "direita" & j< 17 & Mapa.mapa[monstrocimabaixo, monstrodiresq+1] == "O")
        //                {
        //                    Mapa.mapa[monstrocimabaixo, monstrodiresq] = "O";
        //                    return Mapa.mapa[monstrocimabaixo, monstrodiresq + 1] = Monstro.getValor();
        //                }
        //                else if (MovimentoVerticalMonstros() == "cima" & i> 2 & Mapa.mapa[monstrocimabaixo-1, monstrodiresq] == "O")
        //                {
        //                    Mapa.mapa[monstrocimabaixo, monstrodiresq] = "O";
        //                    return Mapa.mapa[monstrocimabaixo - 1, monstrodiresq] = Monstro.getValor();
        //                }
        //                else if (MovimentoVerticalMonstros() == "baixo" & i< 17 & Mapa.mapa[monstrocimabaixo+1, monstrodiresq] == "O")
        //                {
        //                    Mapa.mapa[monstrocimabaixo, monstrodiresq] = "O";
        //                    return Mapa.mapa[monstrocimabaixo + 1, monstrodiresq] = Monstro.getValor();
        //                }
        //                else
        //                {

        //                }
        //            }
        //        }
        //    }
        //    return "none";
        //}

       


    }
}

