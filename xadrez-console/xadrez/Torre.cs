using tabuleiro;


namespace xadrez {
    class Torre : Peca {

        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }

        public override string ToString() {
            return "T";
        }

        private bool podeMover(Posicao pos) {
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] movimentosPossiveis() { // precisa chamar o método override para avisar que está sobrescrevendo 
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            // verificando acima
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor) {
                    break; // força a parada do while
                }
                pos.Linha = pos.Linha - 1;
            }

            // verificando abaixo
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor) {
                    break; // força a parada do while
                }
                pos.Linha = pos.Linha + 1;
            }

            // verificando a direita
            pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor) {
                    break; // força a parada do while
                }
                pos.Coluna = pos.Coluna + 1;
            }

            // verificando a esquerda
            pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor) {
                    break; // força a parada do while
                }
                pos.Coluna = pos.Coluna - 1;
            }

            return mat;
        }

    }
}
