//I chose to select random scriptures to present to the user.
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        RandomScriptures randomScriptures = new RandomScriptures();
        Console.Clear(); // Limpa a tela

            Scripture scripture = randomScriptures.GetRandomScripture();
          
        while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());
            
            Console.WriteLine("\nPressione Enter para continuar ou digite 'quit' para sair.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
                break;

            scripture.HideRandomWords();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
    }
}