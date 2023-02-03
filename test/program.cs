//List for the journal and selection screen.

using System;
using System.IO;

public class Display
{
     public static void Main(string[] args)
    {   
        Write write = new Write();
        deFileLoad deLoadEntry = new deFileLoad();
        string entry = "";
        string deUserEntry = "";
        Console.WriteLine ("Welcome to the journal!");
        Console.WriteLine ("Please select one of the following.");
    while(deUserEntry!="5"){
    var deDisplayList = new List<string>(4);
    {
        deDisplayList.Add ("1. Write");
        deDisplayList.Add ("2. Display");
        deDisplayList.Add ("3. Load");
        deDisplayList.Add ("4. Save");
        deDisplayList.Add ("5. Quit");

        for(int i=0;i<deDisplayList.Count;i++)
        {
            Console.WriteLine(deDisplayList[i]);
        }
    }
        deUserEntry = Console.ReadLine();
        if(deUserEntry == "1"){
            //get prompt
            //entry += write.getInput();
            //Console.WriteLine(entry);
            Prompt prompt = new Prompt();
            prompt.getEntry();
        }
        else if(deUserEntry == "2"){
            Console.WriteLine(entry);
        }
        else if(deUserEntry == "3"){
            entry += deLoadEntry.load();
        }

    }
    }
}
    


