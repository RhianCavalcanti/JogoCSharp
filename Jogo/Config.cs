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

        public static bool NascimentoMonstros()
        {
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
            return true;
        }

        public static bool Pocoes()
        {
            int qtdPocoes = 0;
            int[] horizontal = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            int[] vertical = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            Random rnd = new Random();
            while (qtdPocoes < 8)
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

        public static bool Arma()
        {
            int[] horizontal = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            int[] vertical = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            Random rnd = new Random();
            int indicehorizontal = rnd.Next(horizontal.Length);
            int indicevertical = rnd.Next(vertical.Length);
            int posicaohorizontal = horizontal[indicehorizontal];
            int posicaovertical = vertical[indicevertical];
            if (Mapa.mapa[posicaohorizontal, posicaovertical] == "O" && Mapa.mapa[posicaohorizontal, posicaovertical] != Monstro.getValor())
            {
                Mapa.mapa[posicaohorizontal, posicaovertical] = "W";
            }
            return true;
        }

        public static string ControlesHeroi(Monstro monstro1, Monstro monstro2, Monstro monstro3, Monstro monstro4, Monstro monstro5, Monstro monstro6)
        {
            Heroi hero = new Heroi();
            Monstro[] monstros = { monstro1, monstro2, monstro3, monstro4, monstro5, monstro6 };
            
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
                                else if (Mapa.mapa[cimabaixo, esqdir - 1] == "W")
                                {
                                    hero.pegaArma();
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
                                else if (Mapa.mapa[cimabaixo, esqdir + 1] == "W")
                                {
                                    hero.pegaArma();
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
                                else if (Mapa.mapa[cimabaixo + 1, esqdir] == "W")
                                {
                                    hero.pegaArma();
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
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
                                else if (Mapa.mapa[cimabaixo - 1, esqdir] == "W")
                                {
                                    hero.pegaArma();
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
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
                            case ConsoleKey.Spacebar:
                                hero.contaScore();
                                hero.reduzVida();
                                if(cimabaixo==0)
                                {
                                    cimabaixo = cimabaixo + 1;

                                }
                                else if (esqdir == 0)
                                {
                                    esqdir = esqdir + 1;
                                }
                                for (int index = 0; index < 6; index++)
                                {



                                    if (cimabaixo != 0)
                                    {


                                        if (Mapa.mapa[cimabaixo + 1, esqdir] == monstros[index].getValoratk())
                                        {
                                            monstros[index].reduzVida(hero.getDano());

                                            if (monstros[index].getVida() < 0)
                                            {

                                                Mapa.mapa[cimabaixo + 1, esqdir] = "O";
                                                hero.MatarMonstro();
                                            }
                                        }
                                        else if (Mapa.mapa[cimabaixo - 1, esqdir] == monstros[index].getValoratk())
                                        {
                                            monstros[index].reduzVida(hero.getDano());

                                            if (monstros[index].getVida() < 0)
                                            {
                                                Mapa.mapa[cimabaixo - 1, esqdir] = "O";
                                                hero.MatarMonstro();
                                            }
                                        }
                                    }
                                    else if (esqdir != 0)
                                    {



                                        if (Mapa.mapa[cimabaixo, esqdir + 1] == monstros[index].getValoratk())
                                        {
                                            monstros[index].reduzVida(hero.getDano());

                                            if (monstros[index].getVida() < 0)
                                            {
                                                Mapa.mapa[cimabaixo, esqdir + 1] = "O";
                                                hero.MatarMonstro();
                                            }
                                        }
                                        else if (Mapa.mapa[cimabaixo, esqdir - 1] == monstros[index].getValoratk())
                                        {
                                            monstros[index].reduzVida(hero.getDano());

                                            if (monstros[index].getVida() < 0)
                                            {
                                                Mapa.mapa[cimabaixo, esqdir - 1] = "O";
                                                hero.MatarMonstro();
                                            }
                                        }
                                    }

                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            return "none";
        }
        public static string AtaqueMonstro(Monstro monstro1, Monstro monstro2, Monstro monstro3, Monstro monstro4, Monstro monstro5, Monstro monstro6, Boss boss)
        {
            Heroi hero = new Heroi();
           
            
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (Mapa.mapa[i, j] == "M")
                    {
                        int cimabaixo = i;
                        int esqdir = j;
                        
                            
                            if (Mapa.mapa[cimabaixo + 1, esqdir] == hero.getValor() & monstro1.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro1.getDano());

                            }
                            else if (Mapa.mapa[cimabaixo - 1, esqdir] == hero.getValor() & monstro1.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro1.getDano());
                            }
                            else if (Mapa.mapa[cimabaixo, esqdir + 1] == hero.getValor() & monstro1.getVida() > 0)
                            {
                                
                                hero.reduzVidaAtkMonstro(monstro1.getDano());

                            }
                            else if (Mapa.mapa[cimabaixo, esqdir - 1] == hero.getValor() & monstro1.getVida() > 0)
                            {
                                
                                hero.reduzVidaAtkMonstro(monstro1.getDano());
                                
                            }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            else if (Mapa.mapa[cimabaixo + 1, esqdir] == hero.getValor() & monstro2.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro2.getDano());

                            }
                            else if (Mapa.mapa[cimabaixo - 1, esqdir] == hero.getValor() & monstro2.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro2.getDano());
                            }
                            else if (Mapa.mapa[cimabaixo, esqdir + 1] == hero.getValor() & monstro2.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro2.getDano());

                            }
                            else if (Mapa.mapa[cimabaixo, esqdir - 1] == hero.getValor() & monstro2.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro2.getDano());

                            }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            else if (Mapa.mapa[cimabaixo + 1, esqdir] == hero.getValor() & monstro3.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro3.getDano());

                            }
                            else if (Mapa.mapa[cimabaixo - 1, esqdir] == hero.getValor() & monstro3.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro3.getDano());
                            }
                            else if (Mapa.mapa[cimabaixo, esqdir + 1] == hero.getValor() & monstro3.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro3.getDano());

                            }
                            else if (Mapa.mapa[cimabaixo, esqdir - 1] == hero.getValor() & monstro3.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro3.getDano());

                            }
                            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            else if (Mapa.mapa[cimabaixo + 1, esqdir] == hero.getValor() & monstro4.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro4.getDano());

                            }
                            else if (Mapa.mapa[cimabaixo - 1, esqdir] == hero.getValor() & monstro4.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro4.getDano());
                            }
                            else if (Mapa.mapa[cimabaixo, esqdir + 1] == hero.getValor() & monstro4.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro4.getDano());

                            }
                            else if (Mapa.mapa[cimabaixo, esqdir - 1] == hero.getValor() & monstro4.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro4.getDano());

                            }
                            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            else if (Mapa.mapa[cimabaixo + 1, esqdir] == hero.getValor() & monstro5.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro5.getDano());

                            }
                            else if (Mapa.mapa[cimabaixo - 1, esqdir] == hero.getValor() & monstro5.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro5.getDano());
                            }
                            else if (Mapa.mapa[cimabaixo, esqdir + 1] == hero.getValor() & monstro5.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro5.getDano());

                            }
                            else if (Mapa.mapa[cimabaixo, esqdir - 1] == hero.getValor() & monstro5.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro5.getDano());

                            }
                            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            else if (Mapa.mapa[cimabaixo + 1, esqdir] == hero.getValor() & monstro6.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro6.getDano());

                            }
                            else if (Mapa.mapa[cimabaixo - 1, esqdir] == hero.getValor() & monstro6.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro6.getDano());
                            }
                            else if (Mapa.mapa[cimabaixo, esqdir + 1] == hero.getValor() & monstro6.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro6.getDano());

                            }
                            else if (Mapa.mapa[cimabaixo, esqdir - 1] == hero.getValor() & monstro6.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(monstro6.getDano());

                            }
                            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            else if (Mapa.mapa[cimabaixo + 1, esqdir] == hero.getValor() & boss.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(boss.getDano());

                            }
                            else if (Mapa.mapa[cimabaixo - 1, esqdir] == hero.getValor() & boss.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(boss.getDano());
                            }
                            else if (Mapa.mapa[cimabaixo, esqdir + 1] == hero.getValor() & boss.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(boss.getDano());

                            }
                            else if (Mapa.mapa[cimabaixo, esqdir - 1] == hero.getValor() & boss.getVida() > 0)
                            {

                                hero.reduzVidaAtkMonstro(boss.getDano());

                            }

                        
                    }
                }
            }
            return "none";
        }
    }
}

