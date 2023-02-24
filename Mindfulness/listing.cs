using System;

class Listing{

    string [] prompts = {
        "How did the spirit touch your life today?",
        "What was the highlight of your day?",
        "Why was today good/bad?",
        "When did you do a good thing and see blessings?"
    };

    private string _prompt;

    private int _responseCount;

    private int _duration;

    public Listing(string prompt, int responseCount, int duration)
    {
        _prompt = prompt;
        _responseCount = responseCount;
        _duration = duration;
    }

    public void getPrompt()
    {
        Random random = new Random();
        _prompt = prompts[random.Next(0,4)];
        Console.WriteLine(_prompt);
        Console.WriteLine("List as many responses as you can to the following prompt!");
        string userInput = Console.ReadLine();
        }
    
    
}