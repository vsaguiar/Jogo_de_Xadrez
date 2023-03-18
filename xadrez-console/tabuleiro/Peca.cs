namespace tabuleiro {
    abstract class Peca {

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

        public void incrementarQteMovimentos() {
            QuantidadeMovimentos++;
        }

        public void decrementarQteMovimentos() {
            QuantidadeMovimentos--;
        }

        public bool ExisteMovimentosPossiveis() {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < Tab.Linhas; i++) {
                for (int j = 0; j < Tab.Colunas; j++) {
                    if (mat[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos) {
            return movimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] movimentosPossiveis();

    }
}
