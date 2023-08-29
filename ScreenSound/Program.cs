using System;
using System.Collections.Generic;
using ScreenSound.Menus;
using ScreenSound.Modelos;
using OpenAI_API;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string mensagemDeBoasVindas = "Bem vindo ao Screen Sound!";

            BandaArtista travis = new("Travis Scott");
            travis.AdicionarNota(new Avaliacao(10));
            travis.AdicionarNota(new Avaliacao(9));
            travis.AdicionarNota(new Avaliacao(7));
            BandaArtista post = new("Post Malone");

            Dictionary<string, BandaArtista> bandasRegistradas = new();
            bandasRegistradas.Add(travis.Nome, travis);
            bandasRegistradas.Add(post.Nome, post);

            Dictionary<int, Menu> opcoes = new();
            opcoes.Add(1, new MenuRegistrarBanda());
            opcoes.Add(2, new MenuRegistrarAlbum());
            opcoes.Add(3, new MenuExibirBandasRegistradas());
            opcoes.Add(4, new MenuAvaliarBanda());
            opcoes.Add(5, new MenuAvaliarAlbum());
            opcoes.Add(6, new MenuExibirDetalhes());
            opcoes.Add(-1, new MenuSair());

            void ExibirLogo()
            {
                Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
                Console.WriteLine(mensagemDeBoasVindas);
            }

            void ExibirOpcoesDoMenu()
            {
                ExibirLogo();
                Console.WriteLine("\nDigite 1 para registrar um banda");
                Console.WriteLine("Digite 2 para registrar o álbum de uma banda cadastrada");
                Console.WriteLine("Digite 3 para mostrar todas as bandas");
                Console.WriteLine("Digite 4 para avaliar uma banda");
                Console.WriteLine("Digite 5 para avaliar um album");
                Console.WriteLine("Digite 6 para exibir a detalhes de uma banda");

                Console.WriteLine("Digite -1 para sair");
                Console.Write("\nDigite a sua opção: ");
                string opcaoEscolhida = Console.ReadLine()!; //! -> não aceita valor nulo
                int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

                if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
                {
                    Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
                    menuASerExibido.Executar(bandasRegistradas);
                    if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            }
            ExibirOpcoesDoMenu();
        }
    }
}
