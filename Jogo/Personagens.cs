﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo
{
    public class Heroi
    {

        private static string valor = "H";
        private static int vida = 25;
        private int dano = 1;

        public String getValor()
        {
            return valor;
        }
        
        public void reduzVida()
        {
            vida--;
        }

        public void pegaArma()
        {
            dano++;
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