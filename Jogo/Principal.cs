using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo
{
       
    class Principal
    {
        static void Main(string[] args)
        {
            Mapa.mapa[0, 0] = Heroi.valor;
            switch (Heroi.valor)
            {
                case "H":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    Console.ResetColor();
                    break;

                    
            }

             
            Config.NascimentoMonstros();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {   
                    Console.Write(Mapa.mapa[i, j]+" ");
                    
                }
                Console.WriteLine();
            }
           
        }
       
    }


}
