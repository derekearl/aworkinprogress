using System;

namespace Develop05;

public class Simple : Goal
{
    // private int _goalPoints;
    private string _cwgoalName;
    private string _cwgoalDescription;
    private int _cwgoalPoints;
    
    public void SetVariables(string cwgoalName, string cwgoalDescription, int cwgoalPoints)
    {
        _cwgoalName = cwgoalName;
        _cwgoalDescription = cwgoalDescription;
        _cwgoalPoints = cwgoalPoints;
    }

    public string GetVariables()
    {
        string _cwwrittenPoints = _cwgoalPoints.ToString();
        return $"{_cwgoalName}|{_cwgoalDescription}|{_cwwrittenPoints}";
    }
    protected override int AddPoints(int cwtotalPoints, int cwpointsEarned)
    {
        return cwtotalPoints + cwpointsEarned;
    }

    // Originally: protected override int RecordEvent(string cwfileName, string userGoal)  //, string userGoal
    protected override int RecordEvent(string cwuserChoice, string cwfileName)
    {
        string[] cweventParts = cwuserChoice.Split("|");
        string _cwgType = cweventParts[0];
        string _cwgName = cweventParts[1];
        string _cwgDescription = cweventParts[2];
        string _cwgPoints = cweventParts[3];
        int _cwpoints = int.Parse(_cwgPoints);
        string _cwgComplete = cweventParts[4];
        bool _cwcomplete = bool.Parse(_cwgComplete);

        return _cwpoints;
    }

    protected bool IsComplete(string cwuserChoice, string cwfileName)
    {
        string[] cweventParts = cwuserChoice.Split("|");
        string _cwgType = cweventParts[0];
        string _cwgName = cweventParts[1];
        string _cwgDescription = cweventParts[2];
        string _cwgPoints = cweventParts[3];
        int _cwpoints = int.Parse(_cwgPoints);
        string _cwgComplete = cweventParts[4];
        bool _cwcomplete = bool.Parse(_cwgComplete);

        return _cwcomplete;
    }

}