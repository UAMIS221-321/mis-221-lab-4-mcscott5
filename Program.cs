int menuChoice = 0;
System.Console.WriteLine("Please enter triangle you wish to display: ");
menuChoice = int.Parse(System.Console.ReadLine());

while (menuChoice != 3) {
    if (menuChoice == 1) {
        System.Console.WriteLine("Full triangle");
        System.Random rnd = new System.Random();
        int level; 
        level = rnd.Next(3, 10); 
        for (int i = 0; i < level; i++) {
            for (int j = 0; j <= i; j++){
                System.Console.Write("o ");
            }
            System.Console.WriteLine("\n");
        }
    } else if (menuChoice == 2) {
        System.Console.WriteLine("Partial Triangle");
    } else {
        System.Console.WriteLine("Invalid choice");
    }
    System.Console.WriteLine("Please enter triangle you wish to display: ");
    menuChoice = int.Parse(System.Console.ReadLine());
}