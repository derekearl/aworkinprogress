using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        string book = reference.getBook();
        int chapter = reference.getChapter();
        int verse = reference.getVerse();

        //
        Console.WriteLine($"{book} {chapter} {verse}");

        Scripture scipture = new Scripture();
        string scriptureWords = scipture.getScripture();

        Console.WriteLine(scriptureWords);
        Console.WriteLine("Press Enter to Continue");

    }

    userInput = Console.ReadLine();
    if(userInput != "quit")
    {
        Console.Clear();
    }
}