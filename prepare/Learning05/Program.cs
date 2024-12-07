using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Tatenda N", "Geography");
        Console.WriteLine(assignment.GetSummary());
    

    MathAssignment mathAssignment = new MathAssignment("Tatenda N","Maths", "47", "3-9");
    Console.WriteLine(mathAssignment.GetSummary());
    Console.WriteLine(mathAssignment.GetHomeworkList());
    
    WrittingAssignment writtingAssignment = new WrittingAssignment("Tatenda N","World War II", "History");
    Console.WriteLine(writtingAssignment.GetSummary());
    Console.WriteLine(writtingAssignment.GetWrittingInformation());

    }

}