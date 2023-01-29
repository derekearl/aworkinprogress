// Celestia Wilkey, Logan, Derek, Vishnu
// Date: 01/25/2023 || ⓒ copyright all rights reserved, BYU-I CSE 210
// This is part of the abstraction project.
// --Celeste: Create class Write and create random prompt function
public class Write
{
    public static void Main()
    {
        string[] cwPrompts = new string[5]; 
        cwPrompts[0] = "I am happy because... ";
        cwPrompts[1] = "What did I learn today? ";
        cwPrompts[2] = "What do I want to do tomorrow to make it great? ";
        cwPrompts[3] = "Today, I was inspired by... ";
        cwPrompts[4] = "How did I give and receive appreciation today? ";

        Dictionary<int, (string prompt, string input)> cwEntries = new Dictionary<int, (string prompt, string input)>();
        int cwKeyValue = 0;

        while (true)
        {
            cwKeyValue += 1;
            Random cwRandomize = new Random();
            int cwPromptNumber = cwRandomize.Next(4);
            string cwSelectedPrompt = cwPrompts[cwPromptNumber];
            Console.WriteLine(cwPrompts[cwPromptNumber]);
            Console.WriteLine("Write something! Type 0 to finish.");
            string cwUserEntry = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(cwUserEntry) && string.IsNullOrWhiteSpace(cwSelectedPrompt) || cwUserEntry == "0")
            {
                break;
            }

            cwEntries.Add(cwKeyValue, (cwUserEntry, cwSelectedPrompt));
        }

    }

}