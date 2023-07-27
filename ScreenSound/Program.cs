using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading;

namespace ScreenSound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Episodio ep1 = new(2000, 2, "A descoberta");
            ep1.AdicionarConvidados("Jonathan");
            ep1.AdicionarConvidados("Polyanna");

            Episodio ep2 = new(2000, 1, "O fim");
            ep2.AdicionarConvidados("Carlos");
            ep2.AdicionarConvidados("Thais");

            Podcast podcast = new("Jorge", "+1Podcast");
            podcast.AdicionarEpisodio(ep1);
            podcast.AdicionarEpisodio(ep2);
            podcast.ExibirDetalhes();

            /*BandaArtista travisScott = new BandaArtista("Travis Scott");

            Album albumTravis = new Album("Astroworld");

            Musica musica1 = new Musica(travisScott, "BUTTERFLY EFFECT")
            {
                Duracao = 213,
                Disponivel = true
            };

            Musica musica2 = new Musica(travisScott, "CAN'T SAY")
            {
                Duracao = 240,
                Disponivel = false
            };

            albumTravis.AdicionarMusica(musica1);
            albumTravis.AdicionarMusica(musica2);

            albumTravis.ExibirMusicasDoAlbum();

            

            travisScott.AdicionarAlbum(albumTravis);
            travisScott.ExibirDiscografia();*/


            /*Musica musica1 = new Musica()
            {
                Nome = "Wake UP",
                Artista = "Travis Scott",
                Duracao = 200,
                Disponivel = true                                
            };
            
            Musica musica2 = new Musica()
            {
                Nome = "Can't Say",
                Artista = "Travis Scott",
                Duracao = 300,
                Disponivel = false
            };

            Console.WriteLine(musica1.DescricaoResumida);
            musica1.ExibirFixaDaMusica();
            musica2.ExibirFixaDaMusica();*/


            /*string mensagemDeBoasVindas = "Bem vindo ao Screen Sound!";
            //List<string> listaDasBandas = new List<string> { "U2", "Ozzy", "Kiss"};
            Dictionary<string, List<int>> BandasRegistradas = new Dictionary<string, List<int>>();
            BandasRegistradas.Add("Kiss", new List<int> { 10, 8, 6 });
            BandasRegistradas.Add("The Beatles", new List<int>());

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
                Console.WriteLine("Digite 2 para mostrar todas as bandas");
                Console.WriteLine("Digite 3 para avaliar uma banda");
                Console.WriteLine("Digite 4 para exibir a média de uma banda");
                Console.WriteLine("Digite -1 para sair");
                Console.Write("\nDigite a sua opção: ");
                string opcaoEscolhida = Console.ReadLine()!; //! -> não aceita valor nulo
                int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

                switch (opcaoEscolhidaNumerica)
                {
                    case 1:
                        RegistrarBanda();
                        break;
                    case 2:
                        ExibirBandasRegistradas();
                        break;
                    case 3:
                        AvaliarBanda();
                        break;
                    case 4:
                        ExibirMediaDaBandas();
                        break;
                    case -1:
                        Console.WriteLine($"Tachau :)");
                        break;
                    default:
                        Console.WriteLine("Você digitou uma opção inválida");
                        break;
                }
            }

            void RegistrarBanda()
            {
                Console.Clear();
                ExibirTituloDaOpca("Registro de bandas");
                Console.Write("Nome da banda: ");
                string nomeBanda = Console.ReadLine()!;
                BandasRegistradas.Add(nomeBanda, new List<int>());
                Console.WriteLine($"A banda {nomeBanda}, foi registrada com sucesso");
                Thread.Sleep(2000); //esperar antes de fazer algo
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

            void ExibirBandasRegistradas()
            {
                Console.Clear();
                ExibirTituloDaOpca("Bandas registradas");
                foreach (var banda in BandasRegistradas.Keys)
                {
                    Console.WriteLine(banda);
                }
                Console.Write("\n>>Digite uma tecla para voltar ao menu<< ");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

            void ExibirTituloDaOpca(string titulo)
            {
                int quatidadeDeLetras = titulo.Length;
                string asteriscos = string.Empty.PadLeft(quatidadeDeLetras, '*');
                Console.WriteLine(asteriscos);
                Console.WriteLine(titulo);
                Console.WriteLine(asteriscos + "\n");
            }

            void AvaliarBanda()
            {
                Console.Clear();
                ExibirTituloDaOpca("Avaliar banda");

                Console.Write("Digite o nome da banda: ");
                string nomeDaBanda = Console.ReadLine()!;
                if (BandasRegistradas.ContainsKey(nomeDaBanda))
                {
                    Console.Write($"Qual a nota da {nomeDaBanda}: ");
                    int nota = int.Parse(Console.ReadLine()!);
                    BandasRegistradas[nomeDaBanda].Add(nota);
                    Console.WriteLine($"\nA nota {nota}, foi registrada com sucesso, para a banda {nomeDaBanda}");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ExibirOpcoesDoMenu();
                }
                else
                {
                    Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
                    Console.WriteLine("\n>>Digite uma tecla para voltar ao menu<< ");
                    Console.ReadKey();
                    Console.Clear();
                    ExibirOpcoesDoMenu();
                }
            }

            void ExibirMediaDaBandas()
            {
                Console.Clear();
                ExibirTituloDaOpca("Nota média da Banda");
                Console.Write("Digite o nome da banda: ");
                string nomeDaBanda = Console.ReadLine()!;

                if (BandasRegistradas.ContainsKey(nomeDaBanda))
                {
                    Console.WriteLine($" A nota média da banda {nomeDaBanda} é {BandasRegistradas[nomeDaBanda].Average()}");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ExibirOpcoesDoMenu();
                }
                else
                {
                    Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
                    Console.WriteLine("\n>>Digite uma tecla para voltar ao menu<< ");
                    Console.ReadKey();
                    Console.Clear();
                    ExibirOpcoesDoMenu();
                }
            }


            ExibirOpcoesDoMenu();*/
        }
    }
}
