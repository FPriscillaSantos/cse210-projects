using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Samuel Bennett");
        assignment1.SetTopic("Multiplication");

        assignment1.GetSummary();
    }
}