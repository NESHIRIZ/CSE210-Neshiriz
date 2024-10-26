using System;
using EternalQuestProgram;

namespace EternalQuestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();

            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("---------------------");

            while (true)
            {
                Console.WriteLine("1. Create Goal");
                Console.WriteLine("2. Record Event");
                Console.WriteLine("3. Display Goals");
                Console.WriteLine("4. Save Goals");
                Console.WriteLine("5. Load Goals");
                Console.WriteLine("6. Exit");

                Console.Write("Choose an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        CreateGoal(manager);
                        break;
                    case 2:
                        RecordEvent(manager);
                        break;
                    case 3:
                        DisplayGoals(manager);
                        break;
                    case 4:
                        SaveGoals(manager);
                        break;
                    case 5:
                        LoadGoals(manager);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }

        static void CreateGoal(GoalManager manager)
        {
            Console.Write("Enter goal name: ");
            string goalName = Console.ReadLine();
            Console.Write("Enter goal type (SimpleQuest/EternalQuest/ChecklistQuest): ");
            string goalType = Console.ReadLine();

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
                    Console.Write("Enter target count: ");
                    int targetCount = int.Parse(Console.ReadLine());
                    goal = new ChecklistQuest(goalName, targetCount);
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    return;
            }

            manager.AddGoal(goal);
            Console.WriteLine("Goal created successfully.");
        }

        static void RecordEvent(GoalManager manager)
        {
            Console.Write("Enter goal name: ");
            string goalName = Console.ReadLine();
            manager.RecordEvent(goalName);
            Console.WriteLine("Event recorded successfully.");
        }

        static void DisplayGoals(GoalManager manager)
        {
            manager.DisplayGoals();
        }

        static void SaveGoals(GoalManager manager)
        {
            manager.SaveGoals("goals.txt");
            Console.WriteLine("Goals saved successfully.");
        }

        static void LoadGoals(GoalManager manager)
        {
            manager.LoadGoals("goals.txt");
            Console.WriteLine("Goals loaded successfully.");
        }
    }
}



      