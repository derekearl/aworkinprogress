using System;
using System.Collections.Generic;
using System.Threading;
// This activity draws a single prompt from a list of prompts, and encourages the user to answer questions about it.

namespace Develop04
{
class ReflectingActivity : Activity
    {
        // Declare private fields to store the duration, prompts, questions, and random number generator
        private int duration;
        private List<string> prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        private List<string> questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        private Random rand = new Random();

        // Define a constructor that takes a duration argument
        public ReflectingActivity(int duration)
        {
            this.duration = duration;
        }

        // Define a Start method to begin the activity
        public void Start()
        {
            // // Display starting message and prompt for duration
            Console.WriteLine("Welcome to the Reflection activity!");
            Console.WriteLine($"You will have {duration} seconds to reflect on times in your life when you have shown strength and resilience.");
            Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
            Console.WriteLine("Get Ready!");
            ShowSpinner(4);

            // // Calculate the end time for the activity based on the duration
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(duration);

            // // Loop until the end time is reached
            while (DateTime.Now < endTime)
            {
                // Select a random prompt and display it to the user
                string prompt = prompts[rand.Next(prompts.Count)];
                Console.WriteLine(prompt);
                Thread.Sleep(1500); // pause for 1.5 seconds

                // Loop through the questions and display each one to the user
                foreach (string question in questions)
                {
                    Console.Write("- ");
                    Console.WriteLine(question);
                    Thread.Sleep(1500); // pause for 1.5 seconds
                }
            }

            // Display finishing message when the activity is complete
            Console.WriteLine("\nCongratulations, you have completed the Reflection activity!");
        }
    }
}