using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarAlbum : Menu
    {
        public override void Executar(Dictionary<string, BandaArtista> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpca("Registro de álbuns");
            Console.Write("Digite a Banda, da qual deseja registrar o álbum: ");
            string nomeDaBanda = Console.ReadLine();
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.Write("Digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine();
                BandaArtista banda = bandasRegistradas[nomeDaBanda];
                banda.AdicionarAlbum(new Album(tituloAlbum));
                Console.WriteLine($"O álbum {tituloAlbum} da banda {nomeDaBanda} foi registradio com sucesso");
                Thread.Sleep(4000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
                Console.WriteLine("Digite uma tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
