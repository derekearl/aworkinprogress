 using Newtonsoft.Json;

public class Main
{

    public void Write()
    {
        deConsole.WriteLine("Write");
        string fileName = "journal.json";
        string jsonString = File.ReadAllText("journal.json");
        Console.Writeline("Please write your name: ");
        prompt = Console.ReadLine();
        Console.Writeline("Please write responder's name: ");
        response = Console.ReadLine();

    }
    public void Display()
    {
        deConsole.WriteLine("Display");
        string fileName = "journal.json";
        string jsonString = File.ReadAllText("journal.json");
        foreach (var entry in jsonObject["entries"])
        {
            Console.WriteLine("entry number: {0}", entry.Name);
            Console.WriteLine("prompt: {0}", entry.Value["prompt"]);
            Console.WriteLine("response: {0}", entry.Value["response"]);
        }

    }
    public void Load()
    {
        deConsole.WriteLine("Load");
        string fileName = "journal.json";
        string jsonString = File.ReadAllText("journal.json");
        jsonConvert.DeserializeObject < Dictionary < "entry prompt" >> (jsonString);

    }
    public void Save()
    {
        deConsole.WriteLine("Save");
        string fileName = "journal.json";
        string jsonString = File.ReadAllText("journal.json");
        File.WriteAllText(fileName, jsonString);

        // Deserialize the JSON string into a C# object
        string jsonString = File.ReadAllText("journal.json");
        dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

        // Add the new entry
        int newEntryNumber = jsonObject.entries.Count + 1;
        jsonObject.entries[newEntryNumber.ToString()] = new { prompt = "What did you do today?", response = "I went to the park" };

        // Serialize the object back into a JSON string
        string updatedJsonString = JsonConvert.SerializeObject(jsonObject);
        File.WriteAllText("journal.json", updatedJsonString);


    }

    public void Quit()
    {
        deConsole.WriteLine("Quit");
        string fileName = "journal.json";
        string jsonString = File.ReadAllText("journal.json");
    }
}



// using Newtonsoft.Json;

// //For loops to go though all the entries and print out them and key value pairs

// foreach (var entry in jsonObject["entries"])
// {
//     Console.WriteLine("entry number: {0}", entry.Name);
//     Console.WriteLine("prompt: {0}", entry.Value["prompt"]);
//     Console.WriteLine("response: {0}", entry.Value["response"]);
// }

// // Updated stuff
// // Deserialize the JSON string into a C# object
// string jsonString = File.ReadAllText("journal.json");
// dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

// // Add the new entry
// int newEntryNumber = jsonObject.entries.Count + 1;
// jsonObject.entries[newEntryNumber.ToString()] = new { prompt = "What did you do today?", response = "I went to the park" };

// // Serialize the object back into a JSON string
// string updatedJsonString = JsonConvert.SerializeObject(jsonObject);
// File.WriteAllText("journal.json", updatedJsonString);




// public class Write
// {
//     public static void main()
//     {
//         string[] cwPrompts = new string[5]; 
//         cwPrompts[0] = "I am happy because... ";
//         cwPrompts[1] = "What did I learn today? ";
//         cwPrompts[2] = "What do I want to do tomorrow to make it great? ";
//         cwPrompts[3] = "Today, I was inspired by... ";
//         cwPrompts[4] = "How did I give and receive appreciation today? ";
//         Random cwRandomize = new Random();
//         int cwPromptNumber = cwRandomize.Next(4);
//         Console.WriteLine(cwPrompts[cwPromptNumber]);
//         string cwUserEntry = Console.ReadLine();
//         // Remove this part later
//         Console.WriteLine(cwUserEntry);
//     }

// }

