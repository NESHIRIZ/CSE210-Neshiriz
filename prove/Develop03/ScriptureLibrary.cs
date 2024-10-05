using System;
using System.Collections.Generic;

namespace ScriptureMemoryHelper
{
    public class ScriptureLibrary
    {
        private List<Scripture> _scriptures;

        public ScriptureLibrary()
        {
            _scriptures = new List<Scripture>();
        }

        public void LoadScriptures(string filePath)
        {
            // Implement loading scriptures from file
        }

        public void AddScripture(Scripture scripture)
        {
            _scriptures.Add(scripture);
        }

        public List<Scripture> GetScriptures()
        {
            return _scriptures;
        }
    };
}


