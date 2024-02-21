using System;

class Program
{
    static void Main(string[] args)
    {
        
        Lectures lecture1 = new Lectures("Lecture 1", "description 1", DateTime.Today, DateTime.Now, "Some street 512, City 1, BRA"); 
        lecture1.SpeakerName = "Yoongi";
        lecture1.Capacity = "150";

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("  --- Lecture ---");
        Console.WriteLine(lecture1.DisplayShortDescription());
        Console.WriteLine("");
        Console.WriteLine(lecture1.DisplayStandardDetails());
        Console.WriteLine("");
        lecture1.DisplayFullDetails();

        Receptions reception2 = new Receptions("Reception 2","descripition 2", DateTime.Today, DateTime.Now, "Another Road 5845, Texas, USA");
        reception2.Email = "emailparticipant@blabla.com.br";
        
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("  --- Reception ---");
        Console.WriteLine(reception2.DisplayShortDescription());
        Console.WriteLine("");
        Console.WriteLine(reception2.DisplayStandardDetails());
        Console.WriteLine("");
        reception2.DisplayFullDetails();

        OutdoorGatherings outdoorGatherings3 = new OutdoorGatherings("Reception 2","descripition 2", DateTime.Today, DateTime.Now, "Another Road 5845, Texas, USA");
        outdoorGatherings3.Weather = "Sunny";
        
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("  --- Outdoor Gatherings ---");
        Console.WriteLine(outdoorGatherings3.DisplayShortDescription());
        Console.WriteLine("");
        Console.WriteLine(outdoorGatherings3.DisplayStandardDetails());
        Console.WriteLine("");
        outdoorGatherings3.DisplayFullDetails();
    }
}