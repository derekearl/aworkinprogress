//List for the journal and selection screen.

using System;

public class Display
{
     public static void Main(string[] args)
    {
        Console.WriteLine ("Welcome to the journal!");
        Console.WriteLine ("Please select one of the following.");
    
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

    }
}
    


