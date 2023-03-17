using System;

namespace Develop05
{
    public abstract class Goal
    {
        private string _GoalName = "";
        private string _Description = "";
        private int _GoalPoints;
        private int _TotalPoints;
        private bool _isCompleted;

        // Constructor. This function is called upon the creation of a goal.
        public string StartMessage()
        {
            return $"Your goal is {_GoalName} and its description is {_Description}";
        }
        public string GetDescription()
        {
            return _Description;
        }

        public string GetGoalName()
        {
            return _GoalName;
        }

        public int GetGoalPoints()
        {
            return _GoalPoints;
        }
        
        public void SetGoalName(string GoalName)
        {
            _GoalName = GoalName;
        }
        
        public void SetDescription(string Description)
        {
            _Description = Description;
        }
        
        public void SetGoalPoints(int GoalPoints)
        {
            _GoalPoints = GoalPoints;
        }
        public abstract int AddPoints(int pointsEarned, int totalPoints);
        
        public virtual int RecordEvent(string fileName)
        {
            if (!_isCompleted) {return 0;}
            return _GoalPoints;
        }
        public bool IsCompleted() {return _isCompleted;}
    }
}
