using System;
using System.Threading;
using Microsoft.VisualBasic;

public class ListeningActivity : Activity

{
    private int _count;
    private List<string> _prompts;

    public void ListingActivity(string _name, string _description, int _duration, int _count, List<Strings> _prompts)
    {
        _name = "Welcome to the Listing Activity";
        _description = "\r\n \r\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. \r\nHow long, in seconds, would you like for your session? ";

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