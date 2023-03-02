﻿namespace tabuleiro {
    class Peca {

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QuantidadeMovimentos = 0;
        }




    }
}
