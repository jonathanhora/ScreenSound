using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuExibirDetalhes : Menu
    {
        public override void Executar(Dictionary<string, BandaArtista> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpca("Nota média da Banda");
            Console.Write("Digite o nome da banda: ");
            string nomeDaBanda = Console.ReadLine()!;

            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                BandaArtista banda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine($"A nota média da banda {nomeDaBanda} é {banda.Media}");

                Console.WriteLine("\nDiscografia:");
                foreach(Album albuns in banda.Albums)
                {
                    Console.WriteLine($"{albuns.Nome} -> {albuns.Media}");
                }

                Console.WriteLine("\nDigite uma tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
                Console.WriteLine("\n>>Digite uma tecla para voltar ao menu<< ");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
