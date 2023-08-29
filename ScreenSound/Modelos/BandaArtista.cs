using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    internal class BandaArtista : IAvaliavel
    {
        private List<Album> albums = new List<Album>();
        private List<Avaliacao> notas = new List<Avaliacao>();

        public BandaArtista(string nome) 
        {
            Nome = nome;
        }
        
        public string Nome { get; }
        public double Media
        {
            get
            {
                if(notas.Count == 0)
                    return 0;
                else 
                    return notas.Average(a => a.Nota);
            }
        }

        public string? Resumo { get; set; }

        public List<Album> Albums => albums;

        public void AdicionarAlbum(Album album)
        {
            albums.Add(album);
        }

        public void AdicionarNota(Avaliacao nota)
        {
            notas.Add(nota);
        }

        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia do(a) {Nome}");

            foreach (var album in albums)
            {
                Console.WriteLine(album.Nome);
            }
        }
    }
}
