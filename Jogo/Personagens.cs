using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo
{
    public class Heroi
    {

        private static string valor = "H";
        private static int vida = 25;
        private int dano = 1;
        private static int score = 0;

        public String getValor()
        {
            return valor;
        }
        public int getVida()
        {
            return vida;
        }
        public int getDano()
        {
            return dano;
        }
        public int getScore()
        {
            return score;
        }
        public void reduzVida()
        {
            vida--;
        }

        public void pegaArma()
        {
            dano++;
        }
        public void bebePocao()
        {
            vida = vida + 6;
        }
        public void contaScore()
        {
            score = score + 1;
        }

    }

    public class Destino
    {
        private static string valor = "D";

        public String getValor()
        {
            return valor;
        }
    }

    class Monstro
    {
        private static string valor = "M";
        private int vida = 5;
        private int dano = 1;

        public static String getValor()
        {
            return valor;
        }

        public void reduzVida()
        {
            vida--;
        }
    }


}
