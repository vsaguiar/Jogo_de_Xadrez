namespace tabuleiro {
    class Tabuleiro {


        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas) {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna) {
            return Pecas[linha, coluna];
        }

        //SOBRECARGA
        public Peca peca(Posicao pos) {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public bool existePeca(Posicao pos) {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void ColocarPeca(Peca p, Posicao pos) {
            if (existePeca(pos)) {
                throw new TabuleiroException("Já existe uma peça nessa posição.");
            }
            Pecas[pos.Linha, pos.Coluna] = p; // jogando a peça P lá na matriz de Peças
            p.Posicao = pos;
        }

        public Peca RetirarPeca(Posicao pos) {
            if (peca(pos) == null) { // quer dizer que não tem peça nessa posição
                return null;
            }
            Peca aux = peca(pos); // aux recebendo a peça na posição informada 
            aux.Posicao = null;
            Pecas[pos.Linha, pos.Coluna] = null; // marcando a posição onde estava aux como nula 
            return aux;
        }


        public bool posicaoValida(Posicao pos) {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas) {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos) {
            if (!posicaoValida(pos)) { // o ! significa não
                throw new TabuleiroException("Posição inválida!");
            }
        }



    }
}
