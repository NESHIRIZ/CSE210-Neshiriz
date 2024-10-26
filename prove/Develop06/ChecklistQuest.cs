using System;

namespace EternalQuestProgram
{
    public class ChecklistQuest : ExternalQuest
    {
        private int targetCount;
        private int currentCount;

        public ChecklistQuest(string name, int targetCount) : base(name)
        {
            this.targetCount = targetCount;
            currentCount = 0;
        }

        public override void RecordEvent()
        {
            currentCount++;
            Points += 50;
            if (currentCount == targetCount)
            {
                Points += 500;
            }
        }

        public override string GetDetailsString()
        {
            return $"{Name} ({currentCount}/{targetCount})";
        }
    }
}
