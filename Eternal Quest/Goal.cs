using System;

namespace Develop05
{
    public class Goal
    {
        private string _vsGoalName = "";
        private string _vsDescription = "";
        private int _vsGoalPoints;
        private int _vsTotalPoints;
        private int _vsPointsEarned;
        private bool isCompleted;

        public string StartMessage()
        {
            return $"Your goal is {_vsGoalName} and its description is {_vsDescription}";
        }
        public virtual int AddPoints()
        {
            _vsTotalPoints = _vsPointsEarned + _vsGoalPoints;
            return _vsTotalPoints;
        }
        public virtual int RecordEvent(string fileName)
        {
            if (!isCompleted)
            {
                if (isCompleted)
                {
                    _vsPointsEarned += _vsGoalPoints;
                    return _vsGoalPoints;
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
