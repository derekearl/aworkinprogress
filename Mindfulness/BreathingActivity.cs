using System;
// This prompts the user to match their breaths to a timer for a specified duration. 

namespace mindfulness
{
    public class BreathingActivity : Activity
    {
    // Both of these variables are in seconds. We may need to change them to miliseconds.
    private int inhale = 4; 
    private int exhale = 6; 

    public void BreathCycle() : base()
    {

        // Convert this to a while loop 
        Console.WriteLine("Breathe in...");
        Activity.spinner(inhale);
        Console.WriteLine("Now breathe out...");
        Activity.spinner(exhale);
    }

        
        // Methods: breathCycle(), Activity countDown(), Activity spinner()

    }
}