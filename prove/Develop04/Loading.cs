public class Loading
{
    public static void SpinnerEffect(int durationInSeconds)
    {
        char[] characters = { '\\', '|', '/', '-' };
        int index = 0;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < durationInSeconds)
        {
            Console.Write("\r" + characters[index]);
            index = (index + 1) % characters.Length;
            Thread.Sleep(180);
        }
        Console.WriteLine();
    }

    public static void TwistedEffect(int durationInSeconds)
    {
        string[] characters = {"\r _o_  ", "\r*\\o/* "};
        int index = 0;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < durationInSeconds)
        {
            Console.Write("\r" + characters[index]);
            index = (index + 1) % characters.Length;
            Thread.Sleep(250);
        }
        Console.WriteLine();
    }
    
}


