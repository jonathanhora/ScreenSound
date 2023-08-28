using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuExibirBandasRegistradas : Menu
    {
        public override void Executar(Dictionary<string, BandaArtista> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpca("Bandas registradas");
            foreach (var banda in bandasRegistradas.Keys)
            {
                Console.WriteLine(banda);
            }
            Console.Write("\n>>Digite uma tecla para voltar ao menu<< ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
