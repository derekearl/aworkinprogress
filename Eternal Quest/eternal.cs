using System;

class Eternal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    public void AskUser()
    {
        Console.Write("What is the name of your goal? ");
        Name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        Description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        Points = int.Parse(Console.ReadLine());
    }
}



// Code to test to make sure it asks properly
// class Program
// {
//     static void Main()
//     {
//         var goal = new Eternal();
//         goal.AskUser();

//         Console.WriteLine($"Goal: {goal.Name}");
//         Console.WriteLine($"Description: {goal.Description}");
//         Console.WriteLine($"Points: {goal.Points}");
//     }
// }
