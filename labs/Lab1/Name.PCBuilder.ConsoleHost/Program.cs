decimal cartValue = 0m;


//Calling
DisplayInformation();
DisplayMenu();






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
    Console.WriteLine("N)ew Order");
    Console.WriteLine("Q)uit");

    do
    {
        ConsoleKeyInfo key =Console.ReadKey (true);
        switch(key.Key)
        {
            case ConsoleKey.N: return MenuOption.NewOrder;
            case ConsoleKey.Q: return MenuOption.Quit;
        }

    }while(true);
}

void NewOrder()
{
    cartValue =0;
    Console.WriteLine("Choose A Processor");
    Console.WriteLine("AMD Ryzen 9 5900X");
    Console.WriteLine("AMD Ryzen 7 5700X");
    Console.WriteLine("AMD Ryzen 5 5600X");
    Console.WriteLine("Intel i9-12900K");
    Console.WriteLine("Intel i7-12700K");
    Console.WriteLine("Intel i5-12600K");
}


