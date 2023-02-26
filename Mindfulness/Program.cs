using System;
// Logan Ray, Celestia Wilkey, Derek Earl, Vishnu Soranam
// Date: 02/21/2023 || ⓒ copyright all rights reserved, BYU-I CSE 210
// This is part of the inheritance project.

namespace Develop04
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Menu Options:
            // Start Breathing Activity
            // Start Reflecting Activity
            // Start Listing Activity
            // Quit
            Console.WriteLine("What would you like to do? (1-4)");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            string userSelection = Console.ReadLine();

            // Activities
            Activity breathing = new Activity();
            breathing.SetActivityName("Breathing Activity");
            breathing.SetDescription("For this exercise, you will measure your breathing.");

            Activity reflection = new Activity();
            reflection.SetActivityName("Reflecting Activity");
            reflection.SetDescription("For this exercise, you will be given a prompt to reflect upon.");

            Activity listing = new Activity();
            listing.SetActivityName("Listing Activity");
            listing.SetDescription("For this exercise, you will list as many responses as you can to the following prompt and question.");


            if (userSelection == "1")
            {
                Console.WriteLine(breathing.StartMessage());

                Console.WriteLine("How long, in seconds, would you like your session to be?");
                string userDuration = Console.ReadLine();
                int duration = int.Parse(userDuration);
                breathing.SetDuration(duration);

                // Do Activity

                breathing.EndMessage();
            }
            else if (userSelection == "2")
            {
                Console.WriteLine(reflection.StartMessage());

                Console.WriteLine("How long, in seconds, would you like your session to be?");
                string userDuration = Console.ReadLine();
                int duration = int.Parse(userDuration);
                reflection.SetDuration(duration);

                // Do Activity

                reflection.EndMessage();
            }
            else if (userSelection == "3")
            {
                Console.WriteLine(listing.StartMessage());
                
                Console.WriteLine("How long, in seconds, would you like your session to be?");
                string userDuration = Console.ReadLine();
                int duration = int.Parse(userDuration);
                listing.SetDuration(duration);

                // Do Activity

                listing.EndMessage();
            }
            else
            {
                Console.WriteLine("Thank you for using the Mindfulness Activities!");

            }
        }
    }
}
