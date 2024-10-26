using System;

namespace EternalQuestProgram
{
    public class EternalQuest : ExternalQuest
    {
        public EternalQuest(string name) : base(name)
        {
        }

        public override void RecordEvent()
        {
            Points += 100;
        }

        public override string GetDetailsString()
        {
            return $"{Name} (Eternal)";
        }
    }
}
