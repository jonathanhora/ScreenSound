using System;
using System.Collections.Generic;
using System.Linq;

namespace ScreenSound.Modelos
{
    internal class Podcast
    {
        List<Episodio> episodios = new List<Episodio>();

        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
        }

        public string Host { get; }
        public string Nome { get; }
        public int TotalEpisodios => episodios.Count;

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
            
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Host: {Host}, Podcast: {Nome}\n");
            foreach(var episode in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(episode.Resumo);
            }

            Console.WriteLine($"Esse podcast possui {TotalEpisodios} episodios");

        }
    }
}
