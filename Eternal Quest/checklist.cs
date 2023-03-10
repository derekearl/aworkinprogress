using System;
using System.IO;

class deCheckList
{




private string _goalname;

private string _goalDescription;

private int _goalPoints;

public deCheckList(string goalname, string goalDescription, int goalPoints)
{
    _goalname = goalname;
    _goalDescription = goalDescription;
    _goalPoints = goalPoints;
    Console.WriteLine ("Welcome to the Checklist!");
    Console.WriteLine ("Please select one of the following!");
}

public static void goalList()
{
    string entryList = "";


while(entryList!="4"){
    var displayList = new List<string>(3);
    {
        displayList.Add ("1. Show Goal");
        displayList.Add ("2. Show Description");
        displayList.Add ("1. Show Points");

        for(int i=0;i<displayList.Count;i++)
        {
            Console.WriteLine(displayList[i]);
        }
    }
    entryList = Console.ReadLine();
    if(entryList == "1"){
        Console.ReadLine(goalName);
    }
    else if(entryList == "2"){
        Console.ReadLine(goalDescription);
    }
    else if(entryList == "3"){
        Console.ReadLine(goalPoints);
    }
}

}



}
