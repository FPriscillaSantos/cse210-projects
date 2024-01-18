using System.Runtime.InteropServices;

public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>();

        _prompts.Add ("If I had one thing I could do over today, what would it be?");
        _prompts.Add ("What was the best part of my day?");
        _prompts.Add ("What was the most inspiring thing that happened today?");
        _prompts.Add ("Who was the most interesting person I interacted with today?");
        _prompts.Add ("What was the simplest yet most significant thing that happened today?");
        _prompts.Add ("What did I feel grateful for today?");
        _prompts.Add ("What was the act of kindness that impacted me the most today?");
        _prompts.Add ("What did I learn today?");
        _prompts.Add ("What's the best song I heard today?");
        _prompts.Add ("What spiritual experience did I have today?");
        _prompts.Add ("What would I like to have done today but couldn't?");
    }
    
    

    public string GetRandomPrompt()
    {
        return _prompts[new Random().Next(_prompts.Count)];
    }
} 