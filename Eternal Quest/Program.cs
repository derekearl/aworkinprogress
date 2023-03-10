using System;
using System.Globalization;

namespace Develop05;

public class Program
{
    static void Main(string[] args)
    {
        bool repeat = true;
        while (repeat == true)
        {
            int TotalPoints = 0;
            Console.WriteLine($"You have {TotalPoints} points.");
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.WriteLine("Pick one option from the menu: ");
            string userChoice = Console.ReadLine();

            Goal goal1 = new Goal();
            goal1.SetGoalName("Simple");
            goal1.SetDescription("One time goal.");

            Goal goal2 = new Goal();
            goal2.SetGoalName("Eternal");
            goal2.SetDescription("A never ending goal.");

            Goal goal3 = new Goal();
            goal3.SetGoalName("Checklist");
            goal3.SetDescription("A repetitive goal set for a specified number of times.");

            Goal goal = new Goal();

            if (userChoice == "1")
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                string userChoice2 = Console.ReadLine();

                if (userChoice2 == "1")
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string GoalName = Console.ReadLine();
                    Console.WriteLine("What is the short description of it? ");
                    string Description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    int GoalPoints = int.Parse(Console.ReadLine());
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    Console.WriteLine("What is the bonus for accomplishing it many times? ");
                    goal1.SetGoalName(GoalName);
                    goal1.SetDescription(Description);
                    goal1.SetGoalPoints(GoalPoints);

                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string GoalName = Console.ReadLine();
                    Console.WriteLine("What is the short description of it? ");
                    string Description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    int GoalPoints = int.Parse(Console.ReadLine());
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    Console.WriteLine("What is the bonus for accomplishing it many times? ");
                    goal1.SetGoalName(GoalName);
                    goal1.SetDescription(Description);
                    goal1.SetGoalPoints(GoalPoints);
                }
                else if (userChoice == "3")
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string GoalName = Console.ReadLine();
                    Console.WriteLine("What is the short description of it? ");
                    string Description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    int GoalPoints = int.Parse(Console.ReadLine());
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    Console.WriteLine("What is the bonus for accomplishing it many times? ");
                    goal1.SetGoalName(GoalName);
                    goal1.SetDescription(Description);
                    goal1.SetGoalPoints(GoalPoints);
                }
            }

            else if (userChoice == "2")
            {
                Console.WriteLine(goal.StartMessage());
                Console.WriteLine("The goals are:");
            }

            else if (userChoice == "3")
            {
                Console.WriteLine(goal.StartMessage());
                Console.WriteLine("What is the filename for the goal file? ");
            }

            else if (userChoice == "4")
            {
                Console.WriteLine(goal.StartMessage());
                Console.WriteLine("What is the filename for the goal file? ");
            }

            else if (userChoice == "5")
            {
                Console.WriteLine(goal.StartMessage());
                Console.WriteLine("The goals are:");
                Console.WriteLine("Which goal did you accomplished?");
                
            }

            else
            {
                Console.WriteLine("Thank you for using this program!");
                repeat = false;
            }
        }
    }
}
