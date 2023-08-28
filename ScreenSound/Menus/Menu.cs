using ScreenSound.Modelos;
using System;
using System.Collections.Generic;

namespace ScreenSound.Menus
{
    internal class Menu
    {
        public void ExibirTituloDaOpca(string titulo)
        {
            int quatidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quatidadeDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }

        public virtual void Executar(Dictionary<string, BandaArtista> bandasRegistradas)
        {
            Console.Clear();
        }
    }
}
