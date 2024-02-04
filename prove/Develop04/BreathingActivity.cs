//how many times activities were performed.
//Added another animation (TwistedEffec)
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "\r\n \r\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\r\n", 0)
    {
    }

    public void Start()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("");
            Console.Write("Breathe out...");
            ShowCountdown(8);
            Console.WriteLine("");
        }
        
        DisplayEndingMessage();
    }

}
