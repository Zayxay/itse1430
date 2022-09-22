using System;
class Shop
{
    private decimal _orderTotal;

    public Shop ()
    {
        _orderTotal = 0m;
    }

   public void Start ()
    {
        DisplayInfo();
        DisplayMenu();
    }
    private void Run ()
    {
        
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
       
        SellItem("AMD Ryzen 9 5900X", 1410m);
        //SellItem("AMD Ryzen 7 5700Xd", 1270m);
        //SellItem("AMD Ryzen 5 5600Xd", 1200m);
        //SellItem("Intel i9-12900K", 1590m); 
        //SellItem("Intel i7-12700K", 1400m);
        //SellItem("Intel i5-12600K", 1280m); 
        DisplayOutro();
    }

    private void DisplayInfo ()
    {
        Console.WriteLine("David-Isaiah Ngouambeu");
        Console.WriteLine("ITSE 1430");
        Console.WriteLine("09/15/2022");
        Console.WriteLine("==========");
    }

    private void DisplayMenu ()
    {
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine("Option 1. New Order");
        Console.WriteLine("Option 2. Quit");

        try { 
            int myOptions;
            myOptions = Int32.Parse(Console.ReadLine());
         
            switch (myOptions)
            {
                case 1: Run(); break;
                case 2: DisplayOutro(); break;
                default: Error(); break;
            }
        } catch (FormatException)
        {
            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
            DisplayMenu();
        }
    }
    private void SellItem (string itemName, decimal icost)
    {
        Console.WriteLine($"Would you like to buy {itemName} for {icost:C2}? (y/n)");
        string response = Console.ReadLine().ToUpper();
        try
        {
            if (response.StartsWith("Y"))
            {
                
                _orderTotal += icost;
                SellMemory("8GB", 30m,_orderTotal);
               
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
            SellItem(itemName, icost);
            return;
        }
    }

    private void SellMemory(string memoryName, decimal memoryCost, decimal cart )
    {
        _orderTotal= cart;
        Console.WriteLine($"Your current cart total is {_orderTotal:C2}");
        Console.WriteLine($"Would you like to buy {memoryName} for {memoryCost:C2}? (y/n)");
        string response = Console.ReadLine().ToUpper();
        if (response.StartsWith("Y"))
        {
            cart += memoryCost;
            _orderTotal= cart;
            Console.WriteLine($"Your cart total is {_orderTotal:C2}");
            DisplayMenu();
        }


    }
    private void DisplayOrderTotal ()
    {
        Console.WriteLine($"Your current order total is: {_orderTotal:C2}. ");
    }

    private void DisplayOutro ()
    {
        Console.WriteLine("Thanks for shopping!");
        Console.WriteLine("Press Enter key to exit");
        if (Console.ReadKey().Key != ConsoleKey.Enter)
        {
            Console.WriteLine();
            DisplayMenu();
        }

    }

    private void Error ()
    {

    }
}
