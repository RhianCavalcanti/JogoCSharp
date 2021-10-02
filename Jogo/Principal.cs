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
            Config.NascimentoMonstros();
     

            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------------"+"\n"+ 
                    "-------------------------------------------");
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
                
            }

        }
       
    }


}
