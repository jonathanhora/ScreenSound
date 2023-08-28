using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarBanda : Menu
    {
        public override void Executar(Dictionary<string, BandaArtista> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpca("Registro de bandas");
            Console.Write("Nome da banda: ");
            string nomeBanda = Console.ReadLine()!;
            BandaArtista banda = new BandaArtista(nomeBanda);
            bandasRegistradas.Add(nomeBanda, banda);
            Console.WriteLine($"A banda {nomeBanda}, foi registrada com sucesso");
            Thread.Sleep(2000); //esperar antes de fazer algo
            Console.Clear();
        }
    }
}
