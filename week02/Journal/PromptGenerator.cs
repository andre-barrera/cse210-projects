
public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What is something I learned today, big or small?",
        "Who made a positive impact on my day and why?",
        "What moment today made me feel truly present?",
        "If today was a chapter in my life story, what would the title be?",
        "What am I most grateful for right now, and why?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
