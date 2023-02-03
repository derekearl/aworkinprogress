// Celestia Wilkey, Logan, Derek, Vishnu
// Date: 01/25/2023 || ⓒ copyright all rights reserved, BYU-I CSE 210
// This is part of the abstraction project.
// --Celeste: Create class Write and create random prompt function
using System.IO;
using System.Runtime.CompilerServices;

public class Prompt
{

    string[] cwPrompts = {
    "I am happy because... ",
    "What did I learn today? ",
    "What do I want to do tomorrow to make it great? ",
    "Today, I was inspired by... ",
    "How did I give and receive appreciation today? ",
    }; 
    
    public string cwDate;
    public string cwPrompt;
    public string cwUserInput;

    public void getEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        cwDate = theCurrentTime.ToShortDateString();
        Random random = new Random();
        cwPrompt = cwPrompts[random.Next(0,4)];
        Console.WriteLine(cwPrompt);
        Console.WriteLine("Please Enter a Entry! ");  
        string cwUserInput = Console.ReadLine();
    }

    void setEntry(string input)
    {
        cwUserInput = input;
    }



}