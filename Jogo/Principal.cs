using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo
{
    class Principal
    {
        static void Main(string[] args)
        {

            string[,] mapa = new string[20, 20]
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

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(mapa[i, j]+" ");
                    
                }
                Console.WriteLine();
            }
           
        }
       
    }


}
