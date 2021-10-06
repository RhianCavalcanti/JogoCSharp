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

        public static string MovimentoMonstros(Object obj) 
        {
            Heroi hero = new Heroi();
            int indice;
            Type tipo;

            //int monstrodiresq = j;
            //int monstrocimabaixo = i;
            if (obj.GetType() == typeof(Monstro))
            {
                Monstro monstro = (Monstro) obj;
                if (Monstro.MovimentoHorizontalMonstros() == "esquerda" && monstro.getPosicaoHorizontal() > 2 && monstro.getPosicaoVertical() > 2 && Mapa.mapa[monstro.getPosicaoVertical(), monstro.getPosicaoHorizontal() - 1] == "O")

                {
                    if (monstro.getPosicaoHorizontal() > 0)
                    {
                        indice = -1;
                    }
                    else
                    {
                        indice = 1;
                    }
                    Mapa.mapa[monstro.getPosicaoVertical(), monstro.getPosicaoHorizontal()] = "O";
                    monstro.setPosicaoHorizontal(indice);
                    return Mapa.mapa[monstro.getPosicaoVertical(), monstro.getPosicaoHorizontal()] = Monstro.getValor();
                }
                else if (Monstro.MovimentoHorizontalMonstros() == "direita" && monstro.getPosicaoHorizontal() < 17 && monstro.getPosicaoVertical() < 17 && Mapa.mapa[monstro.getPosicaoVertical(), monstro.getPosicaoHorizontal() + 1] == "O")
                {
                    if (monstro.getPosicaoHorizontal() < 19)
                    {
                        indice = 1;
                    }
                    else
                    {
                        indice = -1;
                    }
                    Mapa.mapa[monstro.getPosicaoVertical(), monstro.getPosicaoHorizontal()] = "O";
                    monstro.setPosicaoHorizontal(indice);
                    return Mapa.mapa[monstro.getPosicaoVertical(), monstro.getPosicaoHorizontal()] = Monstro.getValor();
                }
                else if (Monstro.MovimentoVerticalMonstros() == "cima" && monstro.getPosicaoVertical() > 2 && monstro.getPosicaoHorizontal() > 2 && Mapa.mapa[monstro.getPosicaoVertical() - 1, monstro.getPosicaoHorizontal()] == "O")
                {
                    if (monstro.getPosicaoHorizontal() > 0)
                    {
                        indice = -1;
                    }
                    else
                    {
                        indice = 1;
                    }
                    Mapa.mapa[monstro.getPosicaoVertical(), monstro.getPosicaoHorizontal()] = "O";
                    monstro.setPosicaoVertical(indice);
                    return Mapa.mapa[monstro.getPosicaoVertical(), monstro.getPosicaoHorizontal()] = Monstro.getValor();
                }
                else if (Monstro.MovimentoVerticalMonstros() == "baixo" && monstro.getPosicaoVertical() < 17 && monstro.getPosicaoHorizontal() < 17 && Mapa.mapa[monstro.getPosicaoVertical() + 1, monstro.getPosicaoHorizontal()] == "O")
                {
                    if (monstro.getPosicaoHorizontal() < 19)
                    {
                        indice = 1;
                    }
                    else
                    {
                        indice = -1;
                    }
                    Mapa.mapa[monstro.getPosicaoVertical(), monstro.getPosicaoHorizontal()] = "O";
                    monstro.setPosicaoVertical(indice);
                    return Mapa.mapa[monstro.getPosicaoVertical(), monstro.getPosicaoHorizontal()] = Monstro.getValor();
                }
            }
            else if (obj.GetType() == typeof(Boss))
            {
                Boss boss = (Boss) obj;
                if (Boss.MovimentoHorizontalMonstros() == "esquerda" && boss.getPosicaoHorizontal() > 2 && boss.getPosicaoVertical() > 2 && Mapa.mapa[boss.getPosicaoVertical(), boss.getPosicaoHorizontal() - 1] == "O")
                {
                    if (boss.getPosicaoHorizontal() > 0)
                    {
                        indice = -1;
                    }
                    else
                    {
                        indice = 1;
                    }
                    Mapa.mapa[boss.getPosicaoVertical(), boss.getPosicaoHorizontal()] = "O";
                    boss.setPosicaoHorizontal(indice);
                    return Mapa.mapa[boss.getPosicaoVertical(), boss.getPosicaoHorizontal()] = Boss.getValor();
                }
                else if (Boss.MovimentoHorizontalMonstros() == "direita" && boss.getPosicaoHorizontal() < 17 && boss.getPosicaoVertical() < 17 && Mapa.mapa[boss.getPosicaoVertical(), boss.getPosicaoHorizontal() + 1] == "O")
                {
                    if (boss.getPosicaoHorizontal() < 19)
                    {
                        indice = 1;
                    }
                    else
                    {
                        indice = -1;
                    }
                    Mapa.mapa[boss.getPosicaoVertical(), boss.getPosicaoHorizontal()] = "O";
                    boss.setPosicaoHorizontal(indice);
                    return Mapa.mapa[boss.getPosicaoVertical(), boss.getPosicaoHorizontal()] = Boss.getValor();
                }
                else if (Boss.MovimentoVerticalMonstros() == "cima" && boss.getPosicaoVertical() > 2 && boss.getPosicaoHorizontal() > 2 && Mapa.mapa[boss.getPosicaoVertical() - 1, boss.getPosicaoHorizontal()] == "O")
                {
                    if (boss.getPosicaoHorizontal() > 0)
                    {
                        indice = -1;
                    }
                    else
                    {
                        indice = 1;
                    }
                    Mapa.mapa[boss.getPosicaoVertical(), boss.getPosicaoHorizontal()] = "O";
                    boss.setPosicaoVertical(indice);
                    return Mapa.mapa[boss.getPosicaoVertical(), boss.getPosicaoHorizontal()] = Boss.getValor();
                }
                else if (Boss.MovimentoVerticalMonstros() == "baixo" && boss.getPosicaoVertical() < 17 && boss.getPosicaoHorizontal() < 17 && Mapa.mapa[boss.getPosicaoVertical() + 1, boss.getPosicaoHorizontal()] == "O")
                {
                    if (boss.getPosicaoHorizontal() < 19)
                    {
                        indice = 1;
                    }
                    else
                    {
                        indice = -1;
                    }
                    Mapa.mapa[boss.getPosicaoVertical(), boss.getPosicaoHorizontal()] = "O";
                    boss.setPosicaoVertical(indice);
                    return Mapa.mapa[boss.getPosicaoVertical(), boss.getPosicaoHorizontal()] = Boss.getValor();
                }
                else
                {

                }
            }
            return "none";
        } 

        public static string ControlesHeroi(Monstro monstro1, Monstro monstro2, Monstro monstro3, Monstro monstro4, Monstro monstro5, Monstro monstro6, Boss boss)
        {
            Heroi hero = new Heroi();
            Monstro[] monstros = { monstro1, monstro2, monstro3, monstro4, monstro5, monstro6};
            
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
                                
                                if (esqdir <= 0)
                                {
                                    hero.reduzVida();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo, esqdir - 1] == Monstro.getValor())
                                {
                                    hero.reduzVida();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo, esqdir - 1] == Boss.getValor())
                                {
                                    hero.reduzVidaBoss();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo, esqdir - 1] == "P")
                                {
                                    hero.bebePocao();
                                    hero.contaScore();
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    return Mapa.mapa[cimabaixo, esqdir - 1] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo, esqdir - 1] == "W")
                                {
                                    hero.pegaArma();
                                    hero.reduzVida();
                                    hero.contaScore();
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    return Mapa.mapa[cimabaixo, esqdir - 1] = hero.getValor();
                                }
                                else
                                {
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    hero.reduzVida();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo, esqdir - 1] = hero.getValor();
                                }
                                break;

                            case ConsoleKey.D:
                                if (esqdir >= 19)
                                {
                                    hero.reduzVida();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo, esqdir + 1] == Monstro.getValor())
                                {
                                    hero.reduzVida();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo, esqdir + 1] == Boss.getValor())
                                {
                                    hero.reduzVidaBoss();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo, esqdir + 1] == "P")
                                {
                                    hero.bebePocao();
                                    hero.contaScore();
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    return Mapa.mapa[cimabaixo, esqdir + 1] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo, esqdir + 1] == "W")
                                {
                                    hero.pegaArma();
                                    hero.reduzVida();
                                    hero.contaScore();
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    return Mapa.mapa[cimabaixo, esqdir + 1] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo, esqdir + 1] == "D")
                                {
                                    hero.reduzVida();
                                    hero.contaScore();
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    return Mapa.mapa[cimabaixo, esqdir + 1] = hero.getValor();
                                    
                                }
                                else
                                {
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    hero.reduzVida();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo, esqdir + 1] = hero.getValor();
                                }
                                break;
                            case ConsoleKey.S:
                                if (cimabaixo >= 19)
                                {
                                    hero.reduzVida();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo + 1, esqdir] == Monstro.getValor())
                                {
                                    hero.reduzVida();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo + 1, esqdir] == Boss.getValor())
                                {
                                    hero.reduzVidaBoss();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo + 1, esqdir] == "P")
                                {
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    hero.bebePocao();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo + 1, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo + 1, esqdir] == "W")
                                {
                                    hero.pegaArma();
                                    hero.reduzVida();
                                    hero.contaScore();
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    return Mapa.mapa[cimabaixo + 1, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo + 1, esqdir] == "D")
                                {
                                    hero.reduzVida();
                                    hero.contaScore();
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    return Mapa.mapa[cimabaixo + 1, esqdir] = hero.getValor();
                                }
                                else
                                {
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    hero.reduzVida();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo + 1, esqdir] = hero.getValor();
                                }
                                break;
                            case ConsoleKey.W:
                                if (cimabaixo <= 0)
                                {
                                    hero.reduzVida();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo - 1, esqdir] == Monstro.getValor())
                                {
                                    hero.reduzVida();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo - 1, esqdir] == Boss.getValor())
                                {
                                    hero.reduzVidaBoss();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo - 1, esqdir] == "P")
                                {
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    hero.bebePocao();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo - 1, esqdir] = hero.getValor();
                                }
                                else if (Mapa.mapa[cimabaixo - 1, esqdir] == "W")
                                {
                                    hero.pegaArma();
                                    hero.reduzVida();
                                    hero.contaScore();
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    return Mapa.mapa[cimabaixo - 1, esqdir] = hero.getValor();
                                }
                                else
                                {
                                    Mapa.mapa[cimabaixo, esqdir] = "O";
                                    hero.reduzVida();
                                    hero.contaScore();
                                    return Mapa.mapa[cimabaixo - 1, esqdir] = hero.getValor();
                                }
                                break;
                            case ConsoleKey.Escape:
                                Environment.Exit(0);
                                break;
                            case ConsoleKey.Spacebar:
                                hero.reduzVida();
                                
                                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                if (cimabaixo != 0)
                                {

                                    if (Mapa.mapa[cimabaixo + 1, esqdir] == monstro1.getValoratk())
                                    {
                                        monstro1.reduzVida(hero.getDano());

                                        if (monstro1.getVida() <= 0)
                                        {

                                            Mapa.mapa[cimabaixo + 1, esqdir] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo - 1, esqdir] == monstro1.getValoratk())
                                    {
                                        monstro1.reduzVida(hero.getDano());

                                        if (monstro1.getVida() <= 0)
                                        {
                                            Mapa.mapa[cimabaixo - 1, esqdir] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo + 1, esqdir] == monstro2.getValoratk())
                                    {
                                        monstro2.reduzVida(hero.getDano());

                                        if (monstro2.getVida() <= 0)
                                        {

                                            Mapa.mapa[cimabaixo + 1, esqdir] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo - 1, esqdir] == monstro2.getValoratk())
                                    {
                                        monstro2.reduzVida(hero.getDano());

                                        if (monstro2.getVida() <= 0)
                                        {
                                            Mapa.mapa[cimabaixo - 1, esqdir] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo + 1, esqdir] == monstro2.getValoratk())
                                    {
                                        monstro2.reduzVida(hero.getDano());

                                        if (monstro2.getVida() <= 0)
                                        {

                                            Mapa.mapa[cimabaixo + 1, esqdir] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo - 1, esqdir] == monstro3.getValoratk())
                                    {
                                        monstro3.reduzVida(hero.getDano());

                                        if (monstro3.getVida() <= 0)
                                        {
                                            Mapa.mapa[cimabaixo - 1, esqdir] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo + 1, esqdir] == monstro3.getValoratk())
                                    {
                                        monstro3.reduzVida(hero.getDano());

                                        if (monstro3.getVida() <= 0)
                                        {

                                            Mapa.mapa[cimabaixo + 1, esqdir] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo - 1, esqdir] == monstro4.getValoratk())
                                    {
                                        monstro3.reduzVida(hero.getDano());

                                        if (monstro3.getVida() <= 0)
                                        {
                                            Mapa.mapa[cimabaixo - 1, esqdir] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo + 1, esqdir] == monstro4.getValoratk())
                                    {
                                        monstro4.reduzVida(hero.getDano());

                                        if (monstro4.getVida() <= 0)
                                        {

                                            Mapa.mapa[cimabaixo + 1, esqdir] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo - 1, esqdir] == monstro5.getValoratk())
                                    {
                                        monstro5.reduzVida(hero.getDano());

                                        if (monstro5.getVida() <= 0)
                                        {
                                            Mapa.mapa[cimabaixo - 1, esqdir] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo + 1, esqdir] == monstro5.getValoratk())
                                    {
                                        monstro5.reduzVida(hero.getDano());

                                        if (monstro5.getVida() <= 0)
                                        {

                                            Mapa.mapa[cimabaixo + 1, esqdir] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo - 1, esqdir] == monstro6.getValoratk())
                                    {
                                        monstro6.reduzVida(hero.getDano());

                                        if (monstro6.getVida() <= 0)
                                        {
                                            Mapa.mapa[cimabaixo - 1, esqdir] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo + 1, esqdir] == monstro6.getValoratk())
                                    {
                                        monstro6.reduzVida(hero.getDano());

                                        if (monstro6.getVida() <= 0)
                                        {

                                            Mapa.mapa[cimabaixo + 1, esqdir] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo - 1, esqdir] == boss.getValoratk())
                                    {
                                        boss.reduzVida(hero.getDano());

                                        if (boss.getVida() <= 0)
                                        {
                                            Mapa.mapa[cimabaixo - 1, esqdir] = "O";
                                            hero.MatarBoss();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo + 1, esqdir] == boss.getValoratk())
                                    {
                                        boss.reduzVida(hero.getDano());

                                        if (boss.getVida() <= 0)
                                        {

                                            Mapa.mapa[cimabaixo + 1, esqdir] = "O";
                                            hero.MatarBoss();
                                        }
                                    }
                                }
                                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                else if (esqdir != 0)
                                {
                                    if (Mapa.mapa[cimabaixo, esqdir + 1] == monstro1.getValoratk())
                                    {
                                        monstro1.reduzVida(hero.getDano());

                                        if (monstro1.getVida() <= 0)
                                        {
                                            Mapa.mapa[cimabaixo, esqdir + 1] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo, esqdir - 1] == monstro1.getValoratk())
                                    {
                                        monstro1.reduzVida(hero.getDano());

                                        if (monstro1.getVida() <= 0)
                                        {

                                            Mapa.mapa[cimabaixo, esqdir - 1] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo, esqdir + 1] == monstro2.getValoratk())
                                    {
                                        monstro2.reduzVida(hero.getDano());

                                        if (monstro2.getVida() <= 0)
                                        {
                                            Mapa.mapa[cimabaixo, esqdir + 1] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo, esqdir - 1] == monstro2.getValoratk())
                                    {
                                        monstro2.reduzVida(hero.getDano());

                                        if (monstro2.getVida() <= 0)
                                        {

                                            Mapa.mapa[cimabaixo, esqdir - 1] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo, esqdir + 1] == monstro3.getValoratk())
                                    {
                                        monstro3.reduzVida(hero.getDano());

                                        if (monstro3.getVida() <= 0)
                                        {
                                            Mapa.mapa[cimabaixo, esqdir + 1] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo, esqdir - 1] == monstro3.getValoratk())
                                    {
                                        monstro3.reduzVida(hero.getDano());

                                        if (monstro3.getVida() <= 0)
                                        {

                                            Mapa.mapa[cimabaixo, esqdir - 1] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo, esqdir + 1] == monstro4.getValoratk())
                                    {
                                        monstro4.reduzVida(hero.getDano());

                                        if (monstro4.getVida() <= 0)
                                        {
                                            Mapa.mapa[cimabaixo, esqdir + 1] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo, esqdir - 1] == monstro4.getValoratk())
                                    {
                                        monstro4.reduzVida(hero.getDano());

                                        if (monstro4.getVida() <= 0)
                                        {

                                            Mapa.mapa[cimabaixo, esqdir - 1] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo, esqdir + 1] == monstro5.getValoratk())
                                    {
                                        monstro5.reduzVida(hero.getDano());

                                        if (monstro5.getVida() <= 0)
                                        {
                                            Mapa.mapa[cimabaixo, esqdir + 1] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo, esqdir - 1] == monstro5.getValoratk())
                                    {
                                        monstro5.reduzVida(hero.getDano());

                                        if (monstro5.getVida() <= 0)
                                        {

                                            Mapa.mapa[cimabaixo, esqdir - 1] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo, esqdir + 1] == monstro6.getValoratk())
                                    {
                                        monstro6.reduzVida(hero.getDano());

                                        if (monstro6.getVida() <= 0)
                                        {
                                            Mapa.mapa[cimabaixo, esqdir + 1] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo, esqdir - 1] == monstro6.getValoratk())
                                    {
                                        monstro6.reduzVida(hero.getDano());

                                        if (monstro6.getVida() <= 0)
                                        {

                                            Mapa.mapa[cimabaixo, esqdir - 1] = "O";
                                            hero.MatarMonstro();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo, esqdir + 1] == boss.getValoratk())
                                    {
                                        boss.reduzVida(hero.getDano());

                                        if (boss.getVida() <= 0)
                                        {
                                            Mapa.mapa[cimabaixo, esqdir + 1] = "O";
                                            hero.MatarBoss();
                                        }
                                    }
                                    else if (Mapa.mapa[cimabaixo, esqdir - 1] == boss.getValoratk())
                                    {
                                        monstro1.reduzVida(hero.getDano());

                                        if (monstro1.getVida() <= 0)
                                        {

                                            Mapa.mapa[cimabaixo, esqdir - 1] = "O";
                                            hero.MatarBoss();
                                        }
                                    }

                                }
                                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                

                                
                                
                                hero.contaScore();
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
                    }
                        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    if (Mapa.mapa[i, j] == "B")
                    {
                        int cimabaixo = i;
                        int esqdir = j;
                        if (Mapa.mapa[cimabaixo + 1, esqdir] == hero.getValor() & boss.getVida() > 0)
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

