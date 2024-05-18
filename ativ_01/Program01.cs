using System;
using Struct01;

namespace TAD01
{
    class Program01
    {
        static void Main(string[] args)
        {
            JogadorFutebol jogador01 = new();

            jogador01.nome = "Ian Gabriel";
            jogador01.idade = 25;
            jogador01.posicao = "Atacante";
            jogador01.clube = "Vasco";
            jogador01.numeroGols = 3;
            jogador01.numeroAssistencias = 1;
            jogador01.numeroCartoesAmarelos = 1;
            jogador01.numeroCartoesVermelhos = 0;

            jogador01.Imprimir();
            Console.WriteLine();

            jogador01.RegistrarNumeroCartoesAmarelos();
            jogador01.RegistarNumeroCartoesVermelhos();

            Console.WriteLine("Após registrar cartões: ");
            jogador01.Imprimir();

            Console.WriteLine();
            if (jogador01.VerificarVinculoClube())
            {
                Console.WriteLine("O jogador possui vínculo com um clube.");
            }
            else
            {
                Console.WriteLine("O jogador não possui vínculo com nenhum clube.");
            }
        }
    }
}
