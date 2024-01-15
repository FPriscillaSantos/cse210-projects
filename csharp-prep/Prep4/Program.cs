using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("4. C# Prep 4—Lists");

        List<int> numbers = new List<int>();
        int number;
        int sum = 0;
        int lengh = 0;
        float average = 0;
        int largest = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        do
        {
            Console.Write("Enter number: ");
            string numberChosen = Console.ReadLine();
            number = int.Parse(numberChosen);
            numbers.Add(number);
        } while (number != 0);

        foreach (int item in numbers)
        {
        //    Console.WriteLine(item);
            lengh = lengh + 1;
            sum = sum + item;  
            if (item > largest)
            {
                largest = item;
            };
        }

        lengh = lengh - 1;
        average = (float)sum / lengh;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average.ToString("F15")}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}