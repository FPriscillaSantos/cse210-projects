using System;
using System.Threading;
using System.Collections.Generic;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {

    }

     public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.{_description}");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        SpinnerEffect(4);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!! You have completed {_duration} seconds of the {_name}.\r\n");
        
        TwistedEffect(6);
    }

    protected void SpinnerEffect(int durationInSeconds)
    {
        char[] characters = { '\\', '|', '/', '-' };
        int index = 0;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < durationInSeconds)
        {
            Console.Write("\r" + characters[index]);
            index = (index + 1) % characters.Length;
            Thread.Sleep(180);
        }
        Console.WriteLine();
    }

    protected void TwistedEffect(int durationInSeconds)
    {
        string[] characters = {"\r _o_  ", "\r*\\o/* "};
        int index = 0;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < durationInSeconds)
        {
            Console.Write("\r" + characters[index]);
            index = (index + 1) % characters.Length;
            Thread.Sleep(250);
        }
        Console.WriteLine();
    }
    protected void ShowCountdown(int durationInSeconds)
    {
        for (int i = durationInSeconds; i > 0; i--)
        {
            Console.Write($"\r\n{new string(' ', Console.WindowWidth - 1)}"); // Limpa a linha
            Console.Write($"\r {i} seconds"); // Imprime o próximo número
            Thread.Sleep(1000);
        }
        Console.WriteLine(); 
    }   
}
