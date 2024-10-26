using System;

namespace EternalQuestProgram
{
    public abstract class ExternalQuest
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public ExternalQuest(string name)
        {
            Name = name;
            Points = 5;
        }

        public abstract void RecordEvent();
        public abstract string GetDetailsString();
    }
}