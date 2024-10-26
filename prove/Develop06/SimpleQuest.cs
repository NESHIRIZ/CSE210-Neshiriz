using System;

namespace EternalQuestProgram
{
    public class SimpleQuest : ExternalQuest
    {
        private bool isComplete;

        public SimpleQuest(string name) : base(name)
        {
            isComplete = false;
        }

        public override void RecordEvent()
        {
            isComplete = true;
            Points = 1000;
        }

        public override string GetDetailsString()
        {
            return $"{Name} [{(isComplete ? "X" : " ")}]";
        }
    }
}
