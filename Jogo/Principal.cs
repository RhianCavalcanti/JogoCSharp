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
                        Console.Write(Mapa.mapa[i, j] + " ");

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
