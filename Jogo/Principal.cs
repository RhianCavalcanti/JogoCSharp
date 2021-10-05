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
            //monstro1.nasceMonstro();
            Monstro monstro2 = new Monstro();
            //monstro2.nasceMonstro();
            Monstro monstro3 = new Monstro();
            //monstro3.nasceMonstro();
            Monstro monstro4 = new Monstro();
            //monstro4.nasceMonstro();
            Monstro monstro5 = new Monstro();
            //monstro5.nasceMonstro();
            Monstro monstro6 = new Monstro();
            //monstro6.nasceMonstro();
            Boss boss = new Boss();
           

            do
            {
                
                int vidaheroi = hero.getVida();
                int danoheroi = hero.getDano();
                int score = hero.getScore();
                Console.Clear();
                Console.WriteLine("========================================"+"\n"+ "Hero HP: "+ vidaheroi+" | "+
                    "Hero Damage: "+danoheroi+ " | "+"Score: " +score+"\n"+
                    "========================================");
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
                                Console.Write(character+" ");
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
                Console.WriteLine("\n");
                Config.AtaqueMonstro(monstro1, monstro2, monstro3, monstro4, monstro5, monstro6);
                //Config.AtaqueMonstro(boss);
                Config.ControlesHeroi(monstro1, monstro2, monstro3, monstro4, monstro5, monstro6);
                
                if (monstro1.getVida() > 0)
                {
                    monstro1.MovimentoMonstros();
                    
                }
                if (monstro2.getVida() > 0)
                {
                    monstro2.MovimentoMonstros();
                }
                if (monstro3.getVida() > 0)
                {
                    monstro3.MovimentoMonstros();
                }
                if (monstro4.getVida() > 0)
                {
                    monstro4.MovimentoMonstros();
                }
                if (monstro5.getVida() > 0)
                {
                    monstro5.MovimentoMonstros();
                }
                if (monstro6.getVida() > 0)
                {
                    monstro6.MovimentoMonstros();
                }
                if (boss.getVida() > 0)
                {
                    boss.MovimentoMonstros();
                }
                
            } while (consoleAberto);
        }
    }
}
