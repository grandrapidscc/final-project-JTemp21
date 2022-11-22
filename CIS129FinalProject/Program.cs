using CIS129FinalProject;
using System;

Wizert wizert = new Wizert("Josh", 100, 200);
wizert orc = new Orc(5);
wizert goblin = new Goblin(3);
wizert banshee = new Banshee(8);

int[,] mapGrid = new int[5, 5];


Console.WriteLine(mapGrid);
Console.WriteLine("You awaken inside the labyrinth");

Console.WriteLine("Which direction do you wish to go?")
var direction = Console.ReadLine();

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