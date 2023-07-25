using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public class Musica
    {
        public string Nome { get; set; }
        public string Artista { get;set; }
        public int Duracao { get; set; }
        public bool Disponivel { get;  set; }

        //Só o mode leitura - lambda
        public string DescricaoResumida => 
            $"A música {Nome}, pertence a(o) artista {Artista}";

        public void ExibirFixaDaMusica()
        {
            Console.WriteLine($"\nNome: {Nome}");
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Duração: {Duracao}");

            string disponivel;

            if(Disponivel == true)
            {
                disponivel = "Sim";
            }
            else
            {
                disponivel = "Não";
            }

            Console.WriteLine($"Disponivel: {disponivel}");
        }
    }
}
