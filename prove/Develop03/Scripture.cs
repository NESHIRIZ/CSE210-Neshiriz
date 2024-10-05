using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemoryHelper
{
    public class Scripture 
   {
      private List<Word> _words;
      private string _book;
      private int _chapter;
      private int _verse;
      private string _text;
      private List<string> _tags;

     public Scripture(string book, int chapter, int verse, string text, params string[] tags) 
      {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _text = text;
        _words = SplitTextIntoWords(text);
        _tags = tags.ToList();
      }

      private List<Word> SplitTextIntoWords(string text) 
      {
        return text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(t => new Word(t)).ToList();
      }

      public string GetReference() 
      {
        return $"{_book} {_chapter}:{_verse}";
      }

      public void Display() 
      {
        Console.WriteLine(GetReference());
        Console.WriteLine(string.Join(" ", _words.Select(w => w.GetDisplayText())));
      }

      public bool AllWordsHidden() 
      {
        return _words.All(w => w.IsHidden);
      }

      public void HideRandomWords(int count) 
      {
        var random = new Random();
        for (int i = 0; i < count; i++) 
        {
            var wordIndex = random.Next(_words.Count);
            _words[wordIndex].Hide();
        }
      }

      public string[] GetHiddenWords() 
      {
        return _words.Where(w => w.IsHidden).Select(w => w.GetText()).ToArray();
              }

       public List<Word> GetWords() 
      {
        return _words;
      }

      public List<string> GetTags() 
      {
        return _tags;
     }
   }

}