using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
public class BreathingActivity : Activity
{
    public BreathingActivity(string _name, string _description, int _duration)
    {
        _name = "Welcome to the Breathing Activity";
        _description = "\r\n \r\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. \r\n\r\nHow long, in seconds, would you like for your session? ";
    
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
