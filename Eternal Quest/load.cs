// Set the filename of the input file
string filename = "myFile.txt";

// Create two lists to store the goals and numbers from the input file
List<string> goals = new List<string>();
List<int> numbers = new List<int>();

// Open the input file and read it line by line
using (StreamReader sr = new StreamReader(filename))
{
    string line;
    while ((line = sr.ReadLine()) != null)
    {
        // Check if the line is a number (the first line of the file)
        if (int.TryParse(line, out int number))
        {
            // First line is a number, add it to the numbers list
            numbers.Add(number);
        }
        else
        {
            // Not a number, parse the goal type and other fields
            string[] fields = line.Split(',');
            string goalType = fields[0];
            string goalName = fields[1];
            string goalDescription = fields[2];

            // Depending on the goal type, format the goal string and add it to the goals list
            if (goalType == "SimpleGoal")
            {
                int simpleGoalPoints = int.Parse(fields[3]);
                int simpleGoalProgress = int.Parse(fields[4]);
                string simpleGoalString = $"[ ] {goalName} ({goalDescription})";
                goals.Add(simpleGoalString);
            }
            else if (goalType == "EternalGoal")
            {
                int eternalGoalPoints = int.Parse(fields[3]);
                string eternalGoalString = $"[ ] {goalName} ({goalDescription})";
                goals.Add(eternalGoalString);
            }
            else if (goalType == "ChecklistGoal")
            {
                int checklistGoalPoints = int.Parse(fields[3]);
                int checklistGoalCompletionPoints = int.Parse(fields[4]);
                int checklistGoalCurrentProgress = int.Parse(fields[5]);
                int checklistGoalTotalProgress = int.Parse(fields[6]);
                string checklistGoalString = $"[ ] {goalName} ({goalDescription}) -- Currently completed: {checklistGoalCurrentProgress}/{checklistGoalTotalProgress}";
                goals.Add(checklistGoalString);
            }
            else
            {
                // Unknown goal type, print an error message
                Console.WriteLine($"Unknown goal type: {goalType}");
            }
        }
    }
}

// Print out the list of goals
foreach (string goal in goals)
{
    Console.WriteLine(goal);
}

// Print out the list of numbers
Console.WriteLine();
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
