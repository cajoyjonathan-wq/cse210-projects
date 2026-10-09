using System.IO;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score = 0;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string userInput = "";
        while (userInput != "6")
        {
            DisplayPlayerinfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goal");
            Console.WriteLine(" 3. Save Goal");
            Console.WriteLine(" 4. Load Goal");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                CreateGoal();
            } else if (userInput == "2") {
                ListGoalDetails();
            } else if (userInput == "3") {
                SaveGoals();
            } else if (userInput == "4") {
                LoadGoals();
            } else if (userInput == "5") {
                RecordEvent();
            } else if (userInput == "6")
            {
                Console.WriteLine("Goodbye!");
                Console.Clear();
            }

        }
    }

    public void DisplayPlayerinfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetShortName()}");
            count++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        // if (_goals.Count == 0)
        // {
        //     Console.WriteLine("No goals found.");
        //     return;
        // }

        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            count++;
            
        }
    }

    public void CreateGoal()
    {
        string choice = "";
        string name = "";
        string description = "";
        string points = "";
      

        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        choice = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        points = Console.ReadLine();
      

        if (choice == "1" )
        {
            SimpleGoal newGoal = new SimpleGoal(name, description, points);
            _goals.Add(newGoal);
        } else if (choice == "2") {
            EternalGoal newGoal = new EternalGoal(name, description, points);
            _goals.Add(newGoal);
        } else if (choice == "3") {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing in that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal newGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(newGoal);
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Goal selectedGoal = _goals[index];
        selectedGoal.RecordEvent();

        int points = int.Parse(_goals[index].GetPoints());

        if (selectedGoal is ChecklistGoal cheklistGoal)
        {
            if (cheklistGoal.IsComplete() && cheklistGoal.GetAmountCompleted() == cheklistGoal.GetTarget())
            {
                points += cheklistGoal.GetBonus();
            }
        }
        _score += points;

        Console.WriteLine($"Congratulations! You have earned {points} points!");
        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            string[] parts = line.Split(":");
            string goalType = parts[0];
            string details = parts[1];

            string[] data = details.Split(",");

            if (goalType == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(data[0], data[1], data[2]);
                if (bool.Parse(data[3]))
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            } else if (goalType == "EternalGoal") {
                EternalGoal goal = new EternalGoal(data[0], data[1], data[2]);
                _goals.Add(goal);
            } else if (goalType == "ChecklistGoal")
            {
    
                ChecklistGoal goal = new ChecklistGoal(data[0], data[1], data[2], int.Parse(data[3]), int.Parse(data[4]));

                int autoCompleted = int.Parse(data[5]);
                for (int c = 0; c < autoCompleted; c++)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
        }
    }
}