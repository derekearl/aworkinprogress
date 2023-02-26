using System;
// This is the parent class. All of the child classes will use attributes and methods from this class.

namespace Develop04
{
    public class Activity
    {
        // We need to decide if we want these to be protected or private.
        // If protected, it will be open to all children classes automatically.
        // If private, we will need getters and setters.
        
        private string _activityName = "";
        private string _description = ""; 
        protected int _duration;

        public string StartMessage()
        {
            return $"Welcome to the {_activityName}! {_description}";
        }

        public string GetActivityName()
        {
            return _activityName;
        }

        public void SetActivityName(string activityName)
        {
            _activityName = activityName;
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string description)
        {
            _description = description;
        }
        
        public int GetDuration()
        {
            return _duration;
        }

        public void SetDuration(int duration) 
        {
            _duration = duration;
        }

        public string EndMessage()
        {
            return $"Well done! You've finished {_duration} seconds of the {_activityName}!";
        }

        // Methods!
        public DateTime CountDown(int time)
        {
            DateTime startTime = DateTime.Now;
            TimeSpan seconds = TimeSpan.FromSeconds(time);
            DateTime endTime = startTime + seconds;
            return endTime;
        }

        public void ShowSpinner(int seconds) 
        {
            while (seconds / 2 > 0)
            {
                Console.Write("|");
                Thread.Sleep(500);

                Console.Write("\b \b"); 
                Console.Write("/"); 

                Thread.Sleep(500);

                Console.Write("\b \b"); 
                Console.Write("|"); 

                Thread.Sleep(500);

                Console.Write("\b \b"); 
                Console.Write("\\"); 

                Thread.Sleep(500);
                Console.Write("\b \b"); 

                seconds -= seconds;
            }
        }

    }
}