using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo
{
    class Principal
    {
        static void Main(string[] args)
        {
            Heroi hero = new Heroi();
            Destino destino = new Destino();
            var consoleAberto = true;
            Mapa.mapa[0, 0] = hero.getValor();
            Mapa.mapa[19, 19] = destino.getValor();
            Config.Pocoes();
            Config.Arma();
            Monstro monstro1 = new Monstro();
            Monstro monstro2 = new Monstro();
            Monstro monstro3 = new Monstro();
            Monstro monstro4 = new Monstro();
            Monstro monstro5 = new Monstro();
            Monstro monstro6 = new Monstro();
            Boss boss = new Boss();
            

            do
            {
                int vidaheroi = hero.getVida();
                int danoheroi = hero.getDano();
                int score = hero.getScore();
                if (vidaheroi > 0)//esses dois ifs é para corrigir o erro em que a vida do heroi chegava a 0, mas o programa terminava antes e a vida não chegava a 0
                {


                    Console.Clear();
                    Console.WriteLine("========================================" + "\n" + "Hero HP: " + vidaheroi + " | " +
                        "Hero Damage: " + danoheroi + " | " + "Score: " + score + "\n" +
                        "========================================\n");


                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {

                            string mapacor = Mapa.mapa[i, j];
                            foreach (var character in mapacor.ToUpper())
                            {
                                if (mapacor == "H")
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(character + " ");
                                }
                                else if (mapacor == "M")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(character + " ");
                                }
                                else if (mapacor == "B")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(character + " ");
                                }
                                else if (mapacor == "P")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(character + " ");
                                }
                                else if (mapacor == "D")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(character + " ");
                                }
                                else if (mapacor == "W")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write(character + " ");
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write(character + " ");
                                }
                                Console.ResetColor();
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n======================================== \n" +
                        " [A] to move left.    [D] to move right. \n" +
                        " [W] to move up.      [S] to move down.  \n" +
                        " [SPACE] to attack.   [ESC] to exit.     \n" +
                        "======================================== ");
                    Config.AtaqueMonstro(monstro1, monstro2, monstro3, monstro4, monstro5, monstro6, boss);

                    if (Mapa.mapa[19, 19] == "H")
                    {
                        hero.chegouAoDestino();
                    }
                    Config.ControlesHeroi(monstro1, monstro2, monstro3, monstro4, monstro5, monstro6, boss);

                    if (monstro1.getVida() > 0)
                    {
                        Config.MovimentoMonstros(monstro1);
                    }
                    if (monstro2.getVida() > 0)
                    {
                        Config.MovimentoMonstros(monstro2);
                    }
                    if (monstro3.getVida() > 0)
                    {
                        Config.MovimentoMonstros(monstro3);
                    }
                    if (monstro4.getVida() > 0)
                    {
                        Config.MovimentoMonstros(monstro4);
                    }
                    if (monstro5.getVida() > 0)
                    {
                        Config.MovimentoMonstros(monstro5);
                    }
                    if (monstro6.getVida() > 0)
                    {
                        Config.MovimentoMonstros(monstro6);
                    }
                    if (boss.getVida() > 0)
                    {
                        Config.MovimentoMonstros(boss);
                    }
                }
                if (vidaheroi <= 0)
                {


                    Console.Clear();
                    Console.WriteLine("========================================" + "\n" + "Hero HP: " + vidaheroi + " | " +
                        "Hero Damage: " + danoheroi + " | " + "Score: " + score + "\n" +
                        "========================================\n");


                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {

                            string mapacor = Mapa.mapa[i, j];
                            foreach (var character in mapacor.ToUpper())
                            {
                                if (mapacor == "H")
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(character + " ");
                                }
                                else if (mapacor == "M")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(character + " ");
                                }
                                else if (mapacor == "B")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write(character + " ");
                                }
                                else if (mapacor == "P")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(character + " ");
                                }
                                else if (mapacor == "D")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.Write(character + " ");
                                }
                                else if (mapacor == "W")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write(character + " ");
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write(character + " ");
                                }
                                Console.ResetColor();
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n======================================== \n" +
                        " [A] to move left.    [D] to move right. \n" +
                        " [W] to move up.      [S] to move down.  \n" +
                        " [SPACE] to attack.   [ESC] to exit.     \n" +
                        "======================================== ");
                    Heroi.morre();
                    Environment.Exit(0);

                    Config.AtaqueMonstro(monstro1, monstro2, monstro3, monstro4, monstro5, monstro6, boss);
                    

                    if (Mapa.mapa[19, 19] == "H")
                    {
                        hero.chegouAoDestino();
                    }
                    Config.ControlesHeroi(monstro1, monstro2, monstro3, monstro4, monstro5, monstro6, boss);

                    if (monstro1.getVida() > 0)
                    {
                        Config.MovimentoMonstros(monstro1);
                    }
                    if (monstro2.getVida() > 0)
                    {
                        Config.MovimentoMonstros(monstro2);
                    }
                    if (monstro3.getVida() > 0)
                    {
                        Config.MovimentoMonstros(monstro3);
                    }
                    if (monstro4.getVida() > 0)
                    {
                        Config.MovimentoMonstros(monstro4);
                    }
                    if (monstro5.getVida() > 0)
                    {
                        Config.MovimentoMonstros(monstro5);
                    }
                    if (monstro6.getVida() > 0)
                    {
                        Config.MovimentoMonstros(monstro6);
                    }
                    if (boss.getVida() > 0)
                    {
                        Config.MovimentoMonstros(boss);
                    }
                    
                }
                

                
            } while (consoleAberto);
        }
    }
}
