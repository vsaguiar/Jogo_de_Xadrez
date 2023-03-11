using tabuleiro;
using xadrez;
using System;
using System.Net.Http.Headers;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {

            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();


                while (!partida.terminada) {
                    try {

                        Console.Clear();
                        Tela.ImprimirPartida(partida);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e) {
                        Console.WriteLine(e.Message);
                        Console.WriteLine();
                        Console.Write("Aperte enter para continuar o jogo...");
                        Console.ReadLine(); // esperando o usuário digitar qualquer tecla para repitir a jogada 
                    }
                }
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }


        }
    }
}