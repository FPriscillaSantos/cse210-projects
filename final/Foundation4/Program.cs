using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("          --- Foundation 4 ---");
        Console.WriteLine("");
        Running running1 = new Running(3.0f, 30, 6.0f);
        Cycling cycling2 = new Cycling(9.6f, 30, 19.2f);
        Swimming swimming3 = new Swimming(20, 30, 0);

        Console.WriteLine(running1.GetSummary());
        Console.WriteLine("");
        Console.WriteLine(cycling2.GetSummary());
        Console.WriteLine("");
        Console.WriteLine(swimming3.GetSummary());
    }
}
