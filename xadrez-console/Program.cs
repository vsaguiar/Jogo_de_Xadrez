﻿using tabuleiro;
using xadrez;
using System;
using System.Net.Http.Headers;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            try {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 5));


                Tela.imprimirTabuleiro(tab);

            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }


        }
    }
}