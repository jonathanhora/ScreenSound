using OpenAI_API;
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

            var client = new OpenAIAPI("");

            var chat = client.Chat.CreateConversation();
            chat.AppendSystemMessage($"Resuma o/a {nomeBanda} em 1 paragrafo. Adote um estilo informal.");

            string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
            banda.Resumo = resposta;

            Console.WriteLine(resposta);

            Console.WriteLine($"A banda {nomeBanda}, foi registrada com sucesso");
            //Thread.Sleep(2000); //esperar antes de fazer algo
            Console.WriteLine("\n>>Digite uma tecla para voltar ao menu<< ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
