using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Samuel Bennett");
        assignment1.SetTopic("Multiplication");

        assignment1.GetSummary();

        MathAssignment assignment2 = new MathAssignment();
        assignment2.SetStudentName("Roberto Rodriguez");
        assignment2.SetTopic("Fractions");
        assignment2.SetTextbookSection("7.3");
        assignment2.SetProblems("8-19");

        assignment2.GetSummary();
        assignment2.GetHomeworkList();

        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.SetStudentName("Mary Waters");
        assignment3.SetTopic("European History");
        assignment3.SetTitle("The Causes of World War II by Mary Waters");

        assignment3.GetSummary();
        assignment3.GetWritingInformation();
    }
}