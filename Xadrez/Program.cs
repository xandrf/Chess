﻿using System;
using tabuleiro;
using Xadrez;
namespace Xadrez
{
     class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab =new Tabuleiro(8,8);
            Xadrez.MontarTabuleiro(tab);
            
            Console.ReadKey();

        }
    }
}

