﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public class BandaArtista
    {
        public BandaArtista(string nome) 
        {
            Nome = nome;
        }
        private List<Album> albums = new List<Album>();
        public string Nome { get; }

        public void AdicionarAlbum(Album album)
        {
            albums.Add(album);
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
