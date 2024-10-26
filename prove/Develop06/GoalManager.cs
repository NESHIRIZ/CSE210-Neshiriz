using System;
using System.Collections.Generic;


namespace EternalQuestProgram
{
    public class GoalManager
    {
        private List<ExternalQuest> goals;
        private int totalPoints;

        public GoalManager()
        {
            goals = new List<ExternalQuest>();
            totalPoints = 0;
        }

        public void AddGoal(ExternalQuest goal)
        {
            goals.Add(goal);
        }

        public void RecordEvent(string goalName)
        {
            var goal = goals.Find(g => g.Name == goalName);
            if (goal != null)
            {
                goal.RecordEvent();
                totalPoints += goal.Points;
            }
        }

        public void DisplayGoals()
        {
            Console.WriteLine("Goals:");
            foreach (var goal in goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
            Console.WriteLine($"Total Points: {totalPoints}");
        }

        public void SaveGoals(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(totalPoints);
                foreach (var goal in goals)
                {
                    writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Points}");
                }
            }
        }

        public void LoadGoals(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            totalPoints = int.Parse(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                string goalType = parts[0];
                string goalName = parts[1];
                int goalPoints = int.Parse(parts[2]);
                ExternalQuest goal = null;
                switch (goalType)
                {
                    case "SimpleQuest":
                        goal = new SimpleQuest(goalName);
                        break;
                    case "EternalQuest":
                        goal = new EternalQuest(goalName);
                        break;
                    case "ChecklistQuest":
                        string[] goalDetails = parts[2].Split(':');
                        goal = new ChecklistQuest(goalName, int.Parse(goalDetails[0]));
                        goal.Points = int.Parse(goalDetails[1]);
                        break;
                }
                goals.Add(goal);
            }
        }
    }
}

