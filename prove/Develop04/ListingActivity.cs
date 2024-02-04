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

    public ListingActivity() : base("Listing Activity", "\r\n\r\nThis activity will help you reflect on the good things in your life by listing as many positive aspects as you can.\r\n")
    {
    }

    public void Start()
    {
        DisplayStartingMessage();
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {prompt} ---");
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);
        int _count = 0;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write($"> ");
            string item = Console.ReadLine();
            _count = _count + 1;
        }
        
        Console.WriteLine($"You listed {_count} items.");

        DisplayEndingMessage();
    }
}