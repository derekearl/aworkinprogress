using System;
// // This activity is similar to the Reflecting Activity, but it only contains one list. It aims to get multiple responses from the user and tally them up.

namespace Develop04
{
    public class ListingActivity : Activity
    {
        string [] prompts = {
        "How did the spirit touch your life today?",
        "What was the highlight of your day?",
        "Why was today good/bad?",
        "When did you do a good thing and see blessings?"
        };

        private string _prompt;

        public int GetPrompt(int duration) 
        {
            Random random = new Random();
            _prompt = prompts[random.Next(0,4)];
            Console.WriteLine("Get ready!");
            ShowSpinner(4);
            Console.WriteLine("List as many responses as you can to the following prompt!");
            Console.WriteLine(_prompt);
            int _responseCount = 0;

            DateTime endTime = CountDown(duration);

            while (DateTime.Now < endTime)
            {
                string userInput;
                userInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(userInput))
                {
                    _responseCount += 1;
                }
                else
                {
                    Console.WriteLine("Write something!");
                }
            }
            return _responseCount;
        }
    }
}