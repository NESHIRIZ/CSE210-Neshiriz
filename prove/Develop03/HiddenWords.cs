using System;

public class HiddenWords
{

    public string _text { get; set; }
    public bool _isHidden { get; set; }
    private string[] hiddenWords;
    private string text;

    public HiddenWords(string text, string[] hiddenWords)
    {
        this.text = text;
        this.hiddenWords = hiddenWords;
    }

    public void FillInHiddenWords()
    {
        foreach (string word in hiddenWords)
        {
            if (text.Contains(word))
            {
                text = text.Replace(word, $"[{word}]");
            }
        }
        Console.WriteLine(text);
    }
}
