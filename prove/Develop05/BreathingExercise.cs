using System;

public class BreathingExercise : MindfulnessActivity
{
    private string[] _breathingInstructions = { "Breathe in...", "Hold...", "Breathe out...", "Hold..." };

    public BreathingExercise(int duration) 
        : base("Breathing Exercise", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration) { }

    protected override void ExecuteActivity()
    {
        int cycles = _duration / 10; 
        for (int i = 0; i < cycles; i++)
        {
            foreach (string instruction in _breathingInstructions)
            {
                DisplayAnimation(instruction, 2500); 
                DisplayDots(3, 1000);
            }
        }
    }
}

