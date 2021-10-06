using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo
{
    public class Heroi
    {

        private static string valor = "H";
        private static int vida = 25;
        private static int dano = 1;
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
            if (vida <= 0)
            {
                morre();
                Environment.Exit(0);
            }
        }
        public void reduzVidaBoss()
        {
            vida= vida -2;
            if (vida <= 0)
            {
                morre();
                Environment.Exit(0);
            }
        }
        public void reduzVidaAtkMonstro(int danomonstro)
        {
            vida=vida-danomonstro;
            if (vida <= 0)
            {
                morre();
                Environment.Exit(0);
            }
        }
        public static void morre()
        {
            Console.WriteLine("\n======================================== \n" +
                "======================================== \n" +
                "Infelizmente a caminhada muito longa e os \n" +
                "desafios severos no caminho não permitiram\n" +
                "que o herói completasse a sua saga.");
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
            score = score+1;
        }
        public void MatarMonstro()
        {
            score = score + 5;
        }
        public void MatarBoss()
        {
            score = score + 15;
        }
        public void chegouAoDestino()
        {
            score = score + vida;
            Console.WriteLine("\nParabéns, nobre Herói!!!\n" +
                "Você completou a sua jornada.\n" +
                "Seu score foi de: " + getScore() + ". ");
            Environment.Exit(0);
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
        private static int vida;
        private static int dano;
        protected int indicehorizontal;
        protected int indicevertical;
        protected int posicaohorizontal;
        protected int posicaovertical;
        public Monstro()
        {
            vida = 5;
            dano = 1;
            int[] horizontal = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            int[] vertical = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            Random rnd = new Random();

            indicehorizontal = rnd.Next(horizontal.Length);
            indicevertical = rnd.Next(vertical.Length);
            posicaohorizontal = horizontal[indicehorizontal];
            posicaovertical = vertical[indicevertical];
            if (Mapa.mapa[posicaovertical, posicaohorizontal] == "O" & Mapa.mapa[posicaovertical, posicaohorizontal] != Monstro.getValor())
            {
                Mapa.mapa[posicaovertical, posicaohorizontal] = Monstro.getValor();
            }
        }

        public void nasceMonstro()
        {
            int[] horizontal = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            int[] vertical = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            Random rnd = new Random();

            indicehorizontal = rnd.Next(horizontal.Length);
            indicevertical = rnd.Next(vertical.Length);
            posicaohorizontal = horizontal[indicehorizontal];
            posicaovertical = vertical[indicevertical];
            if (Mapa.mapa[posicaovertical, posicaohorizontal] == "O" & Mapa.mapa[posicaovertical, posicaohorizontal] != Monstro.getValor())
            {
                Mapa.mapa[posicaovertical, posicaohorizontal] = Monstro.getValor();
            }
        }
        public int getPosicaoHorizontal()
        {
            return posicaohorizontal;
        }
        public void setPosicaoHorizontal(int deslocamento)
        {
            posicaohorizontal = posicaohorizontal + deslocamento;
        }
        public int getPosicaoVertical()
        {
            return posicaovertical;
        }
        public void setPosicaoVertical(int deslocamento)
        {
            posicaovertical = posicaovertical + deslocamento;
        }

        public static string MovimentoHorizontalMonstros()
        {
            Random rnd = new Random();
            string direcao;
            string[] sentidos = { "direita", "esquerda" };
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
        
        public String getValoratk()
        {
            return valor;
        }
        public static String getValor()
        {
            return valor;
        }
        public int getDano()
        {
            return dano;
        }
        public int getVida()
        {
            return vida;
        }

        public void reduzVida(int danoheroi)
        {
            vida = vida - danoheroi;
        }
    }
    class Boss : Monstro
    {
        private static String valor = "B";
        private static int vida;
        private static int dano;
        
        public Boss()
        {
            vida = 10;
            dano = 2;

            int[] horizontal = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            int[] vertical = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            Random rnd = new Random();

            indicehorizontal = rnd.Next(horizontal.Length);
            indicevertical = rnd.Next(vertical.Length);
            posicaohorizontal = horizontal[indicehorizontal];
            posicaovertical = vertical[indicevertical];
            if (Mapa.mapa[posicaovertical, posicaohorizontal] == "O") // && Mapa.mapa[posicaovertical, posicaohorizontal] != Boss.getValor())
            {
                Mapa.mapa[posicaovertical, posicaohorizontal] = Boss.getValor();
            }
        }
        public static string getValor()
        {
            return valor;
        }
        public String getValoratk()
        {
            return valor;
        }
        public int getDano()
        {
            return dano;
        }
        public int getVida()
        {
            return vida;
        }
        public void reduzVida(int danoheroi)
        {
            vida = vida - danoheroi;
        }
        public void setPosicaoHorizontal(int deslocamento)
        {
            posicaohorizontal = posicaohorizontal + deslocamento;
        }

        public void setPosicaoVertical(int deslocamento)
        {
            posicaovertical = posicaovertical + deslocamento;
        }
    }


}
