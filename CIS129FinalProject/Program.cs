using CIS129FinalProject;
using System;
using System.Collections.Concurrent;

    Creature Wizert = new Wizert("Josh", 100, 200);
    Creature orc = new Orc("Orc", 5, 0);
    Creature goblin = new Goblin("Goblin", 3, 0);
    Creature banshee = new Banshee("Banshee", 8, 0);

    int[,] mapGrid = new int[5, 5];


    Console.WriteLine(mapGrid);
    Console.WriteLine("You awaken inside the labyrinth");

    Console.WriteLine("Which direction do you wish to go?");
    int direction = Console.ReadLine();

    if (int.IsNullOrEmpty(direction))
    {
        Console.WriteLine("Please enter a valid choice.");
        direction = Console.ReadLine();
    }
    else if (direction >= 5 || direction < 1)
    {
        Console.WriteLine("Please choose a valid direction.")
        direction = Console.ReadLine();
    }
    else
    {
        void ChooseDirection(int direction)
        {
            switch (direction)
            {
                case 1:
                    Console.WriteLine()
            }
        }
    }
}

