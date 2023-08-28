using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuAvaliarBanda : Menu
    {
        public override void Executar(Dictionary<string, BandaArtista> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpca("Avaliar banda");

            Console.Write("Digite o nome da banda: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                BandaArtista banda = bandasRegistradas[nomeDaBanda];
                Console.Write($"Qual a nota da {nomeDaBanda}: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                banda.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota}, foi registrada com sucesso, para a banda {nomeDaBanda}");
                Thread.Sleep(2000);
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
