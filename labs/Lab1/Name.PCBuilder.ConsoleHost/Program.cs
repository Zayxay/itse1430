decimal cartValue = 0m;










//Functions

 void DisplayInformation ()
{
    Console.WriteLine("David-Isaiah Ngouambeu");
    Console.WriteLine("ITSE 1430");
    Console.WriteLine("09/15/2022");
}

 MenuOption DisplayMenu ()
{
    Console.WriteLine($"CART: {cartValue}" ); //TODO
    Console.WriteLine("Q)uit");

    do
    {
        ConsoleKeyInfo key =Console.ReadKey (true);
        switch(key.Key)
        {
            case ConsoleKey.Q: return MenuOption.Quit;
        }

    }while(true);
}


