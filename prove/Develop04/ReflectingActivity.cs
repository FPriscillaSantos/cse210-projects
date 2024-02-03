using System;
using System.Threading;
using Microsoft.VisualBasic;


public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private Random _random = new Random();

    public ReflectingActivity() : base("Reflecting Activity", "\r\n\r\nThis activity will help you reflect on times in your life when you have shown strength and resilience.\r\n")
    {
    }

    public void Start()
    {
        DisplayStartingMessage();
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($" --- {prompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience. \r\nYou may begin in:");
        ShowCountdown(5);
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            for (int i = 0; i < _duration; i++)
            {
                string question = GetRandomQuestion();
                Console.WriteLine($"> {question}");
                SpinnerEffect(8);
            }
            DisplayEndingMessage();
        }
    }

    private string GetRandomQuestion()
    {
        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        return questions[_random.Next(questions.Length)];
    }
}