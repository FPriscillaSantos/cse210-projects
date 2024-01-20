using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int option = 0;

        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();

        while (option != 5)
        {
            if (option == 1)
            {
                Entry newEntry = new Entry(); 
                newEntry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);
                newEntry._entryText = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                newEntry._date = dateText;

                journal.AddEntry(newEntry);

            }
            
            else if (option == 2)
            {
                journal.DisplayAll();
            }

            else if (option == 3)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (option == 4)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                 foreach (char invalidChar in Path.GetInvalidFileNameChars())
                {
                    filename = filename.Replace(invalidChar.ToString(), "");
                }

                journal.SaveToFile(filename);

            }

            else if (option !=1 && option !=2 && option !=3 && option !=4 && option !=5)
            {
                Console.WriteLine("Invalid option");
            }

            Console.WriteLine("\r\nPlease select one of the following choices: \r\n 1. Write \r\n 2. Display \r\n 3. Load\r\n 4. Save \r\n 5. Quit \r\n What would you like to do?");
            string userInput = Console.ReadLine();
            option = int.Parse(userInput);
        }
    }
        
}



            
                    
    
