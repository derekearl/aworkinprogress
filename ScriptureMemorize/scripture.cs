using System;

public class Scripture
{
    // private HideWords()
    // {

    // }

    public void RetrieveRenderedText(string sourceReference, string scripturefile)
    {
        // string sourceReference = "2 Nephi 2:25";
        // string scriptureWords = System.IO.File.ReadAllText(scripturefile);
        string scriptureWords = System.IO.File.ReadAllText(@"Develop03\source.txt");

        // This line may only exist in Program.cs
        Console.WriteLine("Here is a scripture to memorize!");

        System.Console.WriteLine($"{sourceReference}: {scriptureWords}");

        // This line may only exist in Program.cs
        Console.WriteLine("Press 'Enter' to continue! :)");

    }

    // private TotallyHidden()
    // {

    // }
}



// string scriptureWords = "And he said unto me: What desirest thou?";
// string sourceReference = "1 Nephi 11:10";


// !! Turning a string into a list and creating word objects.