using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "City", "State", "USA");
        Lectures lecture1 = new Lectures("Lecture 1", "description 1", DateTime.Today, DateTime.Now, address1);
        lecture1.SpeakerName = "Yoongi";
        lecture1.Capacity = "150";

        Address address2 = new Address("5866 Main St", "Ribeirão Preto", "São Paulo", "USA");
        Lectures lecture2 = new Lectures("Lecture 2", "description 2", DateTime.Today, DateTime.Now, address2);
        lecture1.SpeakerName = "Aang";
        lecture1.Capacity = "200";
        
        Console.WriteLine(lecture1.DisplayShortDescription());
        Console.WriteLine(lecture1.DisplayStandardDetails());
        Console.WriteLine(lecture1.DisplayFullDetails());
    }
}