using System;

namespace Develop05
{
    public class Goal
    {
        private string GoalName = "";
        private string Description = "";
        private int GoalPoints;
        private int TotalPoints;
        private int PointsEarned;
        private bool isCompleted;

        public string StartMessage()
        {
            return $"Your goal is {GoalName} and its description is {Description}";
        }
        public virtual int AddPoints()
        {
            TotalPoints = PointsEarned + GoalPoints;
            return TotalPoints;
        }
        public virtual int RecordEvent(string fileName)
        {
            if (!isCompleted)
            {
                if (isCompleted)
                {
                    PointsEarned += GoalPoints;
                    return GoalPoints;
                }
                return 0;
            }
            return 0;
        }
        public bool IsCompleted()
        {
            if (isCompleted);
            {
                return true;
            }
        }

    }
}
