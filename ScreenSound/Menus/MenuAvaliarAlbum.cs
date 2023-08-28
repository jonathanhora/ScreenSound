

using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ScreenSound.Menus
{
    internal class MenuAvaliarAlbum : Menu
    {
        public override void Executar(Dictionary<string, BandaArtista> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);

            ExibirTituloDaOpca("Avaliar Albun");

            Console.Write("Digite o nome da banda: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                BandaArtista banda = bandasRegistradas[nomeDaBanda];
                Console.Write("Digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine();

                if(banda.Albums.Any(a => a.Nome.Equals(tituloAlbum)))
                {
                    Album album = banda.Albums.First(a => a.Nome.Equals(tituloAlbum));
                    Console.Write($"Qual a nota da {tituloAlbum}: ");
                    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                    album.AdicionarNota(nota);
                    Console.WriteLine($"\nA nota {nota.Nota}, foi registrada com sucesso, para a album {tituloAlbum}");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"O album {tituloAlbum} não foi encontrado");
                    Console.WriteLine("\n>>Digite uma tecla para voltar ao menu<< ");
                    Console.ReadKey();
                    Console.Clear();
                }
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
