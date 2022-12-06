using CIS129FinalProject;
using System;
using System.Collections.Concurrent;
using System.Numerics;


    Creature Wizert = new Wizert("Josh", 100, 200);
    Creature orc = new Creature("Orc", 5, 0);
    Creature goblin = new Goblin("Goblin", 3, 0);
    Creature banshee = new Banshee("Banshee", 8, 0);

    int[,] mapGrid = new int[5, 5];
    
    for (int i = 0; i < mapGrid.Length; i++)
    {
        for (int j = 0; j < mapGrid.Length; j++)
        {
            Console.WriteLine(j);
        }
        Console.WriteLine(i);
    }
    Console.WriteLine(mapGrid);
    Console.WriteLine("You awaken inside the labyrinth");

    Console.WriteLine("Which direction do you wish to go?");
    Console.WriteLine("1. North");
    Console.WriteLine("1. South");
    Console.WriteLine("1. East");
    Console.WriteLine("1. West");


    var input = Console.ReadLine();
    int direction = Convert.ToInt32(input);

    if (direction > 4 || direction < 1)
    {
        Console.WriteLine("Please enter a valid choice.");
        direction = Convert.ToInt32(Console.ReadLine());
    }
    else if (direction >= 5 || direction < 1)
    {
        Console.WriteLine("Please choose a valid direction.");
        direction = Convert.ToInt32(Console.ReadLine());
}
    else
    {
        void ChooseDirection(int direction)
        {
            switch (direction)
            {
                case 1:
                    Console.WriteLine("You move north");
                    break;
                case 2:
                    Console.WriteLine("You move north");
                    break;
                case 3:
                    Console.WriteLine("You move north");
                    break;
                case 4:
                    Console.WriteLine("You move north");
                    break;
        }
    }
}

