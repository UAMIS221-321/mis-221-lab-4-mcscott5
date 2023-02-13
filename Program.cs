﻿string menuChoice;
System.Console.WriteLine("Please enter triangle you wish to display: ");
menuChoice = System.Console.ReadLine();

while (menuChoice != "3")
{
    if (menuChoice == "1")
    {
        GetFull();
    }
    else if (menuChoice == "2")
    {
        GetPartial();
    }
    else
    {
        System.Console.WriteLine("Invalid choice");
    }
    System.Console.WriteLine("Please enter triangle you wish to display: ");
    menuChoice = System.Console.ReadLine();
}

static void GetFull() {
    System.Console.WriteLine("Full triangle");
        System.Random rnd = new System.Random();
        int level;
        level = rnd.Next(3, 10);
        for (int i = 0; i < level; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                System.Console.Write("o ");
            }
            System.Console.WriteLine("\n");
        }
}

static void GetPartial() {
    System.Console.WriteLine("Partial Triangle");
        System.Random rnd = new System.Random();
        int level;
        level = rnd.Next(3, 10);


        for (int i = 0; i < level; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Random rnd2 = new Random();
                int number = rnd2.Next(2);
                if (number == 0)
                {
                    System.Console.Write("o ");
                }
                else
                {
                    System.Console.Write("  ");
                }
            }
            System.Console.WriteLine("\n");
        }
}