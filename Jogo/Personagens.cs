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
            Console.WriteLine("======================================== \n" +
                "======================================== \n" +
                "Infelizmente a caminhada foi muito longa e o herói não completou a sua saga.");
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
        public void MatarMonstro()
        {
            score = score + 5;
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
        private int vida;
        private int dano = 1;
        private int indicehorizontal;
        private int indicevertical;
        private int posicaohorizontal;
        private int posicaovertical;
        public Monstro()
        {
            vida = 5;
            dano = 1;
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
        public string MovimentoMonstros()
        {
            Heroi hero = new Heroi();
            int indice;
            // int monstrodiresq = j;
            //int monstrocimabaixo = i;
            if (MovimentoHorizontalMonstros() == "esquerda" & getPosicaoHorizontal() > 2 & getPosicaoVertical() > 2 & Mapa.mapa[getPosicaoVertical(), getPosicaoHorizontal() - 1] == "O")

            {
                if (getPosicaoHorizontal() > 0)
                {
                    indice = -1;
                }
                else
                {
                    indice = 1;
                }
                Mapa.mapa[getPosicaoVertical(), getPosicaoHorizontal()] = "O";
                setPosicaoHorizontal(indice);
                return Mapa.mapa[getPosicaoVertical(), getPosicaoHorizontal()] = Monstro.getValor();
            }
            
            else if (MovimentoHorizontalMonstros() == "direita" & getPosicaoHorizontal() < 17 & getPosicaoVertical() < 17 & Mapa.mapa[getPosicaoVertical(), getPosicaoHorizontal() + 1] == "O")
            {
                if (getPosicaoHorizontal() < 19)
                {
                    indice = 1;
                }
                else
                {
                    indice = -1;
                }
                Mapa.mapa[getPosicaoVertical(), getPosicaoHorizontal()] = "O";
                setPosicaoHorizontal(indice);
                return Mapa.mapa[getPosicaoVertical(), getPosicaoHorizontal()] = Monstro.getValor();
            }
            
            else if (MovimentoVerticalMonstros() == "cima" & getPosicaoVertical() > 2 & getPosicaoHorizontal() > 2 & Mapa.mapa[getPosicaoVertical() - 1, getPosicaoHorizontal()] == "O")
            {
                if (getPosicaoHorizontal() > 0)
                {
                    indice = -1;
                }
                else
                {
                    indice = 1;
                }
                Mapa.mapa[getPosicaoVertical(), getPosicaoHorizontal()] = "O";
                setPosicaoVertical(indice);
                return Mapa.mapa[getPosicaoVertical(), getPosicaoHorizontal()] = Monstro.getValor();
            }
            
            else if (MovimentoVerticalMonstros() == "baixo" & getPosicaoVertical() < 17 & getPosicaoHorizontal() < 17 & Mapa.mapa[getPosicaoVertical() + 1, getPosicaoHorizontal()] == "O")
            {
                if (getPosicaoHorizontal() < 19)
                {
                    indice = 1;
                }
                else
                {
                    indice = -1;
                }
                Mapa.mapa[getPosicaoVertical(), getPosicaoHorizontal()] = "O";
                setPosicaoVertical(indice);
                return Mapa.mapa[getPosicaoVertical(), getPosicaoHorizontal()] = Monstro.getValor();
            }
            
            else
            {

            }


            return "none";
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
            //Console.WriteLine(mons);
        }
    }
    class Boss : Monstro
    {
        private int vida;
        private int dano;
        public Boss()
        {
            vida = 10;
            dano = 2;
        }
    }


}
