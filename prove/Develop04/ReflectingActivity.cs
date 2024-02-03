using System;
using System.Threading;
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public void ListingActivity(string _name, string _description, int _duration, List<string> _prompts, List<string> _questions)
    {
        _name = "Welcome to the Reflecting Activity";
        _description = "\r\n \r\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. \r\n\r\nHow long, in seconds, would you like for your session? ";

        Console.Clear();
        Console.WriteLine($"{_name}{_description}");
        int _seconds = Convert.ToInt32(Console.ReadLine());
        _duration = _seconds;

        Console.Clear();
        Console.WriteLine("Get ready...");
        Loading.SpinnerEffect(4);
        
        //funcionamento aqui

        Console.WriteLine("Well done!!");
        Loading.TwistedEffect(4);

    }
}