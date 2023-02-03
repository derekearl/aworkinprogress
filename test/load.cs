using System;
using System.IO;

public class deFileLoad {
    public string load() {
        string deFileLoaded = "";
        string userFile = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(userFile);

        foreach (string line in lines) {
            deFileLoaded += line;
        }
        return deFileLoaded;
    }
}