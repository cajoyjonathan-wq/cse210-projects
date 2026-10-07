public class BreathingActivity : Activity
{
    public BreathingActivity() :base ("The Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", 0)
    {
    }
    
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            base.ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            base.ShowCountDown(6);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}