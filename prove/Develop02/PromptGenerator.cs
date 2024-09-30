using System;
using System.Collections.Generic;

// PromptGenerator class to generate random prompts
public class PromptGenerator
{
    private string[] prompts;

    public PromptGenerator(string[] prompts)
    {
        this.prompts = prompts;
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Length)];
    }
}
