using System;

namespace Develop05;
class Program
{
    static void Main(string[] args)
    {
        int totalPoints = 0;
        // Goals
        Goal goal1 = new Goal();
        goal1.SetGoalName("Simple");
        goal1.SetGoalDescription("One time goal.");

        Goal goal2 = new Goal();
        goal2.SetGoalName("Eternal");
        goal2.SetGoalDescription("A never ending goal.");

        Goal goal3 = new Goal();
        goal3.SetGoalName("Checklist");
        goal3.SetGoalDescription("A repetetive goal set for a specified number of times.");

        Console.WriteLine($"You have {totalPoints} points.");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine("Select a choice from the menu: ");

        string userChoice = Console.ReadLine();


    }
}