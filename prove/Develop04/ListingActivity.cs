using System;
using System.Threading;
using Microsoft.VisualBasic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity() : base("Listing Activity", "\r\n\r\nThis activity will help you reflect on the good things in your life by listing as many positive aspects as you can.\r\n\r\n")
    {
    }

    public void Start()
    {
        DisplayStartingMessage();
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Let's start listing...");
        Thread.Sleep(2000); // Pause por 2 segundos antes de começar a listagem
        Console.WriteLine("Enter your items:");
        for (int i = 1; i <= _duration; i++)
        {
            Console.Write($"Item {i}: ");
            string item = Console.ReadLine();
            // Aqui você poderia armazenar os itens em uma lista, banco de dados, etc.
        }
        Console.WriteLine($"You've listed {_duration} items.");

        DisplayEndingMessage();
    }
}