using System;
class Shop
{
    private decimal _orderTotal;
    private string _processorName;
    private decimal _processorPrice;
    private string _memName;
    private decimal _memPrice;

    public Shop ()
    {
        _orderTotal = 0m;
        _processorName="";
        _processorPrice = 0m;
        _memName="";
        _memPrice = 0m;
    }

    public void Start ()
    {
        DisplayInfo();
        DisplayMenu();
    }
    private void Run ()
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine("==========================");
        BuyProcessor();


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
        Console.WriteLine("Option 2. View Order");
        Console.WriteLine("Option 3. Clear Order");
        Console.WriteLine("Option 4. Quit");





        try
        {
            int myOptions;
            myOptions = Int32.Parse(Console.ReadLine());

            switch (myOptions)
            {
                case 1: Run(); break;
                case 2: ViewOrder(_processorName, _processorPrice, _memName, _memPrice, _orderTotal); break;
                case 3: ClearOrder(_processorName, _processorPrice, _memName, _memPrice, _orderTotal); break;
                case 4: DisplayOutro(); break;
                default: Error(); break;
            }
        } catch (FormatException)
        {
            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
            DisplayMenu();
        }
    }

    private void BuyProcessor ()
    {
        Console.Clear();
        Console.WriteLine("Press 1----- To buy the AMD Ryzen 9 5900X Processor for $1410.00");
        Console.WriteLine("Press 2----- To buy the AMD Ryzen 7 5700X Processor for $1270.00");
        Console.WriteLine("Press 3----- To buy the AMD Ryzen 5 5600X Processor for $1200.00");
        Console.WriteLine("Press 4----- To buy the Intel i9-12900K Processor for $1590.00");
        Console.WriteLine("Press 5----- To buy the Intel i7-12700K Processor for $1400.00");
        Console.WriteLine("Press 6----- To buy the Intel i5-12600K Processor for $1280.00");
        int response = Int32.Parse(Console.ReadLine());
        try
        {
            switch (response)
            {
                case 1: _processorName="AMD Ryzen 9 5900X"; _processorPrice=1410; _orderTotal=1410; BuyMemory(); break;
                case 2: _processorName="AMD Ryzen 7 5700X"; _processorPrice=1270; _orderTotal=1270; BuyMemory(); break;
                case 3: _processorName="AMD Ryzen 5 5600X"; _processorPrice=1200; _orderTotal=1200; BuyMemory(); break;
                case 4: _processorName="Intel i9-12900K"; _processorPrice=1590; _orderTotal = 1590; BuyMemory(); break;
                case 5: _processorName="Intel i7-12700K"; _processorPrice=1400; _orderTotal=1400; BuyMemory(); break;
                case 6: _processorName="Intel i5-12600K"; _processorPrice=1200; _orderTotal=1200; BuyMemory(); break;
                default: Error(); break;
            }
        } catch (FormatException)
        {

            Error();
        }
    }

    private void BuyMemory ()
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine("Press 1----- To buy 8 GB of memory for $30");
        Console.WriteLine("Press 2----- To buy 16 GB of memory for $40");
        Console.WriteLine("Press 3----- To buy 32 GB of memory for $90");
        Console.WriteLine("Press 4----- To buy 64 GB for memory $410");
        Console.WriteLine("Press 5----- To buy 128 GB of memory for $600");
        int response = Int32.Parse(Console.ReadLine());
        if (response <= 5)
        {
            switch (response)
            {
                case 1: _memName="8 GB"; _memPrice=30; _orderTotal= _memPrice + _processorPrice; DisplayMenu(); break;
                case 2: _memName="16 GB"; _memPrice=40; _orderTotal=_memPrice + _processorPrice; DisplayMenu(); break;
                case 3: _memName="32 GB"; _memPrice=90; _orderTotal=_memPrice + _processorPrice; DisplayMenu(); break;
                case 4: _memName="64 GB"; _memPrice=410; _orderTotal = _memPrice + _processorPrice; DisplayMenu(); break;
                case 5: _memName="128 GB"; _memPrice=600; _orderTotal=_memPrice + _processorPrice; DisplayMenu(); break;

            }
        } else
        {

            Error();
        }
    }
    private void DisplayOrderTotal ()
    {
        Console.WriteLine($"Your current order total is: {_orderTotal:C2}. ");
    }

    private void DisplayOutro ()
    {
        Console.Clear();
        Console.WriteLine("Thanks for shopping!");
        Console.WriteLine("Press Enter key to exit");
        if (Console.ReadKey().Key != ConsoleKey.Enter)
        {
            Console.WriteLine();
            DisplayMenu();
        } else Environment.Exit(0);

    }

    private void ViewOrder ( string itemName, decimal icost, string memoryName, decimal memoryCost, decimal cart )
    {
        Console.Clear();
        if (itemName == "")
        {
            Console.WriteLine($"There is no order yet.        Cart:{cart:C2}");
            DisplayMenu();
        } else
        {
            Console.WriteLine($"Processor: {itemName}    {icost:C2}");
            Console.WriteLine($"Memory: {memoryName}                      {memoryCost:C2}");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Total:                   {cart:C2}");
        }
        Console.WriteLine("To return to menu press the M key");
        if (Console.ReadKey().Key != ConsoleKey.M)
        {
            Console.WriteLine("Incorrect input automatic redirection.");
            DisplayMenu();
        } else DisplayMenu();

    }

    private void ClearOrder ( string itemName, decimal icost, string memoryName, decimal memoryCost, decimal cart )
    {
        Console.Clear();
        Console.WriteLine("Are you sure you would like to clear your order.  (Y/N)");
        string response = Console.ReadLine().ToUpper();

        if (response.StartsWith("Y"))
        {
            _memName="";
            _memPrice=0;
            _orderTotal=0;
            _processorName="";
            _processorPrice=0;
            DisplayMenu();
        } else if (response.StartsWith("N"))
        {
            DisplayMenu();
        } else
        {
            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
            ClearOrder(itemName, icost, memoryName, memoryCost, cart);

        }


    }

    private void ModifyOrder ( string itemName, decimal icost, string memoryName, decimal memoryCost, decimal cart )
    {
        Console.Clear();
        if (itemName == "")
        {
            Console.WriteLine($"There is no order yet.        Cart:{cart:C2}");
            DisplayMenu();
        }
        else
        {
            Console.WriteLine("Here are your current componets");
            Console.WriteLine("========================");
            Console.WriteLine($"{itemName} for {icost}");
            Console.WriteLine($"{memoryName} for {memoryCost}");
            return;
        }


    }



    private void Error ()
    {
        Console.Clear();
        _orderTotal = 0;
        Console.WriteLine("Youv have entered an incorrect input, restarting order");
        DisplayMenu();
    }
}
