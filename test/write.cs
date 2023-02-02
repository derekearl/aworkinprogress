// Celestia Wilkey, Logan, Derek, Vishnu
// Date: 01/25/2023 || ⓒ copyright all rights reserved, BYU-I CSE 210
// This is part of the abstraction project.
// --Celeste: Create class Write and create random prompt function
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;

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

        DateTime theCurrentTime = DateTime.Now;
        string cwDate = theCurrentTime.ToShortDateString();
        string cwPromptNumber2 = "";
        string cwUserInput = "";

        void setPrompt(string prompt)
        {
            cwPromptNumber2 = prompt;
        }

        void setEntry(string input)
        {
            cwUserInput = input;
        }

    }

}