//using System;
//class Shop
//{
//    private decimal _orderTotal;
//    private string _processorName;
//    private decimal _processorPrice;
//    private string _memName;
//    private decimal _memPrice;

//    public Shop ()
//    {
//        _orderTotal = 0m;
//        _processorName="";
//        _processorPrice = 0m;
//        _memName="";
//        _memPrice = 0m;
//    }

//    public void Start ()
//    {
//        DisplayInfo();
//        DisplayMenu();
//    }
//    private void Run ()
//    {

//        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");

//        SellItem("AMD Ryzen 9 5900X", 1410m);
//        DisplayOutro();
//    }

//    private void DisplayInfo ()
//    {
//        Console.WriteLine("David-Isaiah Ngouambeu");
//        Console.WriteLine("ITSE 1430");
//        Console.WriteLine("09/15/2022");
//        Console.WriteLine("==========");
//    }

//    private void DisplayMenu ()
//    {
//        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
//        Console.WriteLine("Option 1. New Order");
//        Console.WriteLine("Option 2. View Order");
//        Console.WriteLine("Option 3. Quit");


//        try
//        {
//            int myOptions;
//            myOptions = Int32.Parse(Console.ReadLine());

//            switch (myOptions)
//            {
//                case 1: _processorName="hello"; Run(); break;
//                case 2: ViewOrder(_processorName, _processorPrice, _memName, _memPrice, _orderTotal); break;
//                case 3: DisplayOutro(); break;
//                default: Error(); break;
//            }
//        } catch (FormatException)
//        {
//            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
//            DisplayMenu();
//        }
//    }
//    private void SellItem ( string itemName, decimal icost )
//    {
//        Console.WriteLine($"Would you like to buy {itemName} for {icost:C2}? (y/n)");

//        string response = Console.ReadLine().ToUpper();

//        if (response.StartsWith("Y"))
//        {
//            _processorName = itemName;
//            _processorPrice=icost;
//            _orderTotal += icost;
//            SellMemory("8GB", 30m, _orderTotal);

//        } else if (response.StartsWith("N"))
//        {
//            SellItem1("AMD Ryzen 7 5700Xd", 1270m);
//        } else
//        {
//            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
//            SellItem(itemName, icost);


//        }
//    }
//    private void SellItem1 ( string itemName, decimal icost )
//    {
//        Console.WriteLine($"Would you like to buy {itemName} for {icost:C2}? (y/n)");
//        string response = Console.ReadLine().ToUpper();

//        if (response.StartsWith("Y"))
//        {
//            _processorName = itemName;
//            _processorPrice=icost;
//            _orderTotal += icost;
//            SellMemory("8GB", 30m, _orderTotal);

//        } else if (response.StartsWith("N"))
//        {
//            SellItem2("AMD Ryzen 5 5600Xd", 1200m);
//        } else
//        {
//            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
//            SellItem1(itemName, icost);

//        }
//    }

//    private void SellItem2 ( string itemName, decimal icost )
//    {
//        Console.WriteLine($"Would you like to buy {itemName} for {icost:C2}? (y/n)");
//        string response = Console.ReadLine().ToUpper();

//        if (response.StartsWith("Y"))
//        {
//            _processorName = itemName;
//            _processorPrice=icost;
//            _orderTotal += icost;
//            SellMemory("8GB", 30m, _orderTotal);

//        } else if (response.StartsWith("N"))
//        {
//            SellItem3("Intel i9-12900K", 1590m);
//        } else
//        {
//            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
//            SellItem2(itemName, icost);

//        }
//    }

//    private void SellItem3 ( string itemName, decimal icost )
//    {
//        Console.WriteLine($"Would you like to buy {itemName} for {icost:C2}? (y/n)");
//        string response = Console.ReadLine().ToUpper();

//        if (response.StartsWith("Y"))
//        {
//            _processorName = itemName;
//            _processorPrice=icost;
//            _orderTotal += icost;
//            SellMemory("8GB", 30m, _orderTotal);

//        } else if (response.StartsWith("N"))
//        {
//            SellItem4("Intel i7-12700K", 1400m);
//        } else
//        {
//            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
//            SellItem3(itemName, icost);

//        }
//    }
//    private void SellItem4 ( string itemName, decimal icost )
//    {
//        Console.WriteLine($"Would you like to buy {itemName} for {icost:C2}? (y/n)");
//        string response = Console.ReadLine().ToUpper();

//        if (response.StartsWith("Y"))
//        {
//            _processorName = itemName;
//            _processorPrice=icost;
//            _orderTotal += icost;
//            SellMemory("8GB", 30m, _orderTotal);

//        } else if (response.StartsWith("N"))
//        {
//            SellItem5("Intel i5-12600K", 1280m);
//        } else
//        {
//            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
//            SellItem4(itemName, icost);

//        }
//    }

//    private void SellItem5 ( string itemName, decimal icost )
//    {
//        Console.WriteLine($"Would you like to buy {itemName} for {icost:C2}? (y/n)");
//        string response = Console.ReadLine().ToUpper();
//        try
//        {
//            if (response.StartsWith("Y"))
//            {
//                _processorName = itemName;
//                _processorPrice=icost;
//                _orderTotal += icost;
//                SellMemory("8GB", 30m, _orderTotal);

//            } else if (response.StartsWith("N"))
//            {
//                DisplayMenu();
//            }
//        } finally
//        {
//            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
//            SellItem5(itemName, icost);

//        }
//    }
//    private void SellMemory ( string memoryName, decimal memoryCost, decimal cart )
//    {
//        _orderTotal= cart;
//        Console.WriteLine($"Your current cart total is {_orderTotal:C2}");
//        Console.WriteLine($"Would you like to buy {memoryName} for {memoryCost:C2}? (y/n)");
//        string response = Console.ReadLine().ToUpper();

//        if (response.StartsWith("Y"))
//        {
//            _memName= memoryName;
//            _memPrice=memoryCost;
//            cart += memoryCost;
//            _orderTotal= cart;
//            Console.WriteLine($"Your cart total is {_orderTotal:C2}");
//            DisplayMenu();
//        } else if (response.StartsWith("N"))
//        {
//            SellMemory2("16BG", 40, _orderTotal);
//        } else
//        {
//            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
//            SellMemory(memoryName, memoryCost, cart);
//        }

//    }

//    private void SellMemory2 ( string memoryName, decimal memoryCost, decimal cart )
//    {
//        _orderTotal= cart;
//        Console.WriteLine($"Your current cart total is {_orderTotal:C2}");
//        Console.WriteLine($"Would you like to buy {memoryName} for {memoryCost:C2}? (y/n)");
//        string response = Console.ReadLine().ToUpper();

//        if (response.StartsWith("Y"))
//        {
//            _memName= memoryName;
//            _memPrice=memoryCost;
//            cart += memoryCost;
//            _orderTotal= cart;
//            Console.WriteLine($"Your cart total is {_orderTotal:C2}");
//            DisplayMenu();
//        } else if (response.StartsWith("N"))
//        {
//            SellMemory3("32GB", 90, _orderTotal);
//        } else
//        {
//            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
//            SellMemory2(memoryName, memoryCost, cart);

//        }

//    }

//    private void SellMemory3 ( string memoryName, decimal memoryCost, decimal cart )
//    {
//        _orderTotal= cart;
//        Console.WriteLine($"Your current cart total is {_orderTotal:C2}");
//        Console.WriteLine($"Would you like to buy {memoryName} for {memoryCost:C2}? (y/n)");
//        string response = Console.ReadLine().ToUpper();

//        if (response.StartsWith("Y"))
//        {
//            _memName= memoryName;
//            _memPrice=memoryCost;
//            cart += memoryCost;
//            _orderTotal= cart;
//            Console.WriteLine($"Your cart total is {_orderTotal:C2}");
//            DisplayMenu();
//        } else if (response.StartsWith("N"))
//        {
//            SellMemory4("64GB", 410, _orderTotal);
//        } else
//        {
//            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
//            SellMemory3(memoryName, memoryCost, cart);

//        }
//    }
//    private void SellMemory4 ( string memoryName, decimal memoryCost, decimal cart )
//    {
//        _orderTotal= cart;
//        Console.WriteLine($"Your current cart total is {_orderTotal:C2}");
//        Console.WriteLine($"Would you like to buy {memoryName} for {memoryCost:C2}? (y/n)");
//        string response = Console.ReadLine().ToUpper();

//        if (response.StartsWith("Y"))
//        {
//            _memName= memoryName;
//            _memPrice=memoryCost;
//            cart += memoryCost;
//            _orderTotal= cart;
//            Console.WriteLine($"Your cart total is {_orderTotal:C2}");
//            DisplayMenu();
//        } else if (response.StartsWith("N"))
//        {
//            SellMemory5("128GB", 600, _orderTotal);
//        } else
//        {
//            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
//            SellMemory4(memoryName, memoryCost, cart);

//        }

//    }
//    private void SellMemory5 ( string memoryName, decimal memoryCost, decimal cart )
//    {
//        _orderTotal= cart;
//        Console.WriteLine($"Your current cart total is {_orderTotal:C2}");
//        Console.WriteLine($"Would you like to buy {memoryName} for {memoryCost:C2}? (y/n)");
//        string response = Console.ReadLine().ToUpper();

//        if (response.StartsWith("Y"))
//        {
//            _memName= memoryName;
//            _memPrice=memoryCost;
//            cart += memoryCost;
//            _orderTotal= cart;
//            Console.WriteLine($"Your cart total is {_orderTotal:C2}");
//            DisplayMenu();
//        } else if (response.StartsWith("N"))
//        {
//            DisplayMenu();
//        } else
//        {
//            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
//            SellMemory5(memoryName, memoryCost, cart);

//        }

//    }
//    private void DisplayOrderTotal ()
//    {
//        Console.WriteLine($"Your current order total is: {_orderTotal:C2}. ");
//    }

//    private void DisplayOutro ()
//    {
//        Console.WriteLine("Thanks for shopping!");
//        Console.WriteLine("Press Enter key to exit");
//        if (Console.ReadKey().Key != ConsoleKey.Enter)
//        {
//            Console.WriteLine();
//            DisplayMenu();
//        } else Environment.Exit(0);

//    }

//    private void ViewOrder ( string itemName, decimal icost, string memoryName, decimal memoryCost, decimal cart )
//    {
//        if (itemName == "")
//        {
//            Console.WriteLine($"There is no order yet.        Cart:{cart:C2}");
//            DisplayMenu();
//        } else
//        {
//            Console.WriteLine($"Processor: {itemName}    {icost:C2}");
//            Console.WriteLine($"Memory: {memoryName}                      {memoryCost:C2}");
//            Console.WriteLine("-------------------------------------------");
//            Console.WriteLine($"Total:                   {cart:C2}");
//        }
//    }



//    private void Error ()
//    {

//    }
//}
