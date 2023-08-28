using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    internal class Album : IAvaliavel
    {
        private List<Musica> musicas = new();
        private List<Avaliacao> notas = new();

        public Album(string nome)
        {
            Nome = nome;
        }

        
        public string Nome { get; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);
       

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
            foreach (var musica in musicas)
            {
                Console.WriteLine($">> {musica.Nome}");
            }
            Console.WriteLine($"\nDuração do álbum : {DuracaoTotal} minutos");
        }

        public void AdicionarNota(Avaliacao nota)
        {
            notas.Add(nota);
        }

        public double Media
        {
            get
            {
                if (notas.Count == 0) return 0;
                else return notas.Average(n => n.Nota);
            }
        }
    }
}
