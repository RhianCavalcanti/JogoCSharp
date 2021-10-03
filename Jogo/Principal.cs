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
            Config.NascimentoMonstros();
            Config.Pocoes();
           

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
                Config.MovimentoMonstros();
                Config.MovimentoHeroi();
            }while (consoleAberto);

        }
       
    }


}
