using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        RandomScriptures randomScriptures = new RandomScriptures();

        // Loop principal do programa
        while (true)
        {
            Console.Clear(); // Limpa a tela do console

            // Seleciona uma escritura aleatória
            Scripture scripture = randomScriptures.GetRandomScripture();

            // Exibe a escritura selecionada
            Console.WriteLine(scripture.GetDisplayText());

            // Prompt para continuar ou encerrar o programa
            Console.WriteLine("\nPressione Enter para continuar ou digite 'quit' para sair.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
                break;

            // Oculta algumas palavras aleatórias na escritura
            scripture.HideRandomWords();

            // Verifica se todas as palavras estão ocultas
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nTodas as palavras foram ocultadas. O programa será encerrado.");
                break;
            }
        }
    }
}