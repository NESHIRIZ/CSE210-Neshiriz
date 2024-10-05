using System;

namespace ScriptureMemoryHelper
{
    public class Word
    {
        public string _text { get; set; }
    public bool _isHidden { get; set; }

         public string GetText()
        {
        return _text;
        }

    public void SetText(string value)
    {
        _text = value;
    }
        public string Text
        {
        get { return _text; }
        set { _text = value; }
        }

         public bool IsHidden
       {
        get { return _isHidden; }
        set { _isHidden = value; }
        }

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        public string GetDisplayText()
        {
            return _isHidden ? "_____ " : _text + " ";
        }

        public void Hide()
        {
            _isHidden = true;
        }

        public bool isHidden
        {
            get { return _isHidden; }
        }
    }
}
