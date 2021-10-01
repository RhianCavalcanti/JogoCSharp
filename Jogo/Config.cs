using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo
{
    class Config
    {
        struct Entidades
        {
            public string valor;
            public int vida;
            public int dano;
            

            public Entidades(string valor, int vida, int dano, int score)
            {
                this.valor = valor;
                this.vida = vida;
                this.dano = dano;
             

            }


        }
        
        public static string MovimentoHorizontalMonstros()
        {
            Random rnd = new Random();
            string direcao;
            string[] sentidos = {"direita","esquerda" };
            int indice = rnd.Next(sentidos.Length);
            direcao = sentidos[indice];

            return direcao;
        }

        public static string MovimentoVerticalMonstros()
        {
            Random rnd = new Random();
            string direcao;
            string[] sentidos = { "cima", "baixo" };
            int indice = rnd.Next(sentidos.Length);
            direcao = sentidos[indice];

            return direcao;
        }



    }
}
