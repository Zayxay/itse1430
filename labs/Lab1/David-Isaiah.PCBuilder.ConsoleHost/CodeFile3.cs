
using System;
class Shop
{
    private decimal _orderTotal;
    private string _processorName;
    private decimal _processorPrice;
    private string _memName;
    private decimal _memPrice;
    private string _primaryStorage;
    private decimal _primaryStoragePrice;
    private string _secondaryStorage;
    private decimal _secondaryStoragePrice;
    private string _graphicsName;
    private decimal _graphicsPrice;
    private string _operatingName;
    private decimal _operatingPrice;

    public Shop ()
    {
        _orderTotal = 0m;
        _processorName="";
        _processorPrice = 0m;
        _memName="";
        _memPrice = 0m;
        _primaryStorage ="";
        _primaryStoragePrice=0m;
        _secondaryStorage="";
        _secondaryStoragePrice=0m;
        _graphicsName="";
        _graphicsPrice=0;
        _operatingName="";
        _operatingPrice=0;

    }

    public void Start ()
    {
        DisplayInfo();
        DisplayMenu();
    }
    private void Run ()
    {
        Console.Clear();
        if (_operatingName != "")
        {
            Console.Clear ();
            Console.WriteLine($"You have ordered a {_processorName:C2} for {_processorPrice:C2} \n You have ordered a {_memName:C2} for {_memPrice:C2}\n You have ordered a {_primaryStorage} for {_primaryStoragePrice:C2}\nYou have ordered a {_secondaryStorage} for {_secondaryStoragePrice:C2}\nYou have ordered a {_graphicsName} for {_graphicsPrice:C2}\nYou have ordered {_operatingName} for {_operatingPrice:C2} ");
            DisplayMenu();
        }
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine("====================================");
        BuyProcessor();


    }

    private void DisplayInfo ()
    {
        Console.WriteLine("David-Isaiah Ngouambeu");
        Console.WriteLine("ITSE 1430");
        Console.WriteLine("09/15/2022");
        Console.WriteLine("=====================================");
    }

    private void DisplayMenu ()
    {

        Console.WriteLine("=====================================");
        Console.WriteLine();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Enter the corresponding number with a presented option ");
        Console.WriteLine();
        Console.WriteLine("Option 1. New Order");
        Console.WriteLine("Option 2. View Order");
        Console.WriteLine("Option 3. Clear Order");
        Console.WriteLine("Option 4. Modify Order");
        Console.WriteLine("Option 5. Quit");





        try
        {
            int myOptions;
            myOptions = Int32.Parse(Console.ReadLine());

            switch (myOptions)
            {
                case 1: Run(); break;
                case 2: ViewOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 3: ClearOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 4: ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 5: DisplayOutro(); break;
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
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine();
        Console.WriteLine("Press 1) To buy the AMD Ryzen 9 5900X Processor for $1410.00");
        Console.WriteLine("Press 2) To buy the AMD Ryzen 7 5700X Processor for $1270.00");
        Console.WriteLine("Press 3) To buy the AMD Ryzen 5 5600X Processor for $1200.00");
        Console.WriteLine("Press 4) To buy the Intel i9-12900K Processor for $1590.00");
        Console.WriteLine("Press 5) To buy the Intel i7-12700K Processor for $1400.00");
        Console.WriteLine("Press 6) To buy the Intel i5-12600K Processor for $1280.00");
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
                default: BuyProcessor(); break;
            }
        } catch (Exception ex)
        {
            Error();
        }

            
        
    }

    private void BuyMemory ()
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine();
        Console.WriteLine("Press 1) To buy 8 GB of memory for $30");
        Console.WriteLine("Press 2) To buy 16 GB of memory for $40");
        Console.WriteLine("Press 3) To buy 32 GB of memory for $90");
        Console.WriteLine("Press 4) To buy 64 GB for memory $410");
        Console.WriteLine("Press 5) To buy 128 GB of memory for $600");
        int response = Int32.Parse(Console.ReadLine());
        if (response <= 5)
        {
            switch (response)
            {
                case 1: _memName="8 GB"; _memPrice=30; _orderTotal= _memPrice + _processorPrice;    BuyPrimaryStorage(); break;
                case 2: _memName="16 GB"; _memPrice=40; _orderTotal=_memPrice + _processorPrice;    BuyPrimaryStorage(); break;
                case 3: _memName="32 GB"; _memPrice=90; _orderTotal=_memPrice + _processorPrice;    BuyPrimaryStorage(); break;
                case 4: _memName="64 GB"; _memPrice=410; _orderTotal = _memPrice + _processorPrice; BuyPrimaryStorage(); break;
                case 5: _memName="128 GB"; _memPrice=600; _orderTotal=_memPrice + _processorPrice;  BuyPrimaryStorage(); break;
                
            }
        } else
        {

            Error();
        }
    }
    
    private void BuyPrimaryStorage ()
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine();
        Console.WriteLine("Press 1)    To buy SSD 356 GB for your primary storgae for $90");
        Console.WriteLine("Press 2)    To buy SSD 512 GB for your primary storgae for $100");
        Console.WriteLine("Press 3)     To buy SSD 1 TB for your primary storgae for $125");
        Console.WriteLine("Press 4)    To buy SSD 2 TB for your primary storgae for $230");
        
        int response = Int32.Parse(Console.ReadLine());
        if (response <= 5)
        {
            switch (response)
            {
                case 1:_primaryStorage="SSD 356 GB"; _primaryStoragePrice=90; _orderTotal= _memPrice + _processorPrice+_primaryStoragePrice;  BuySecondaryStorage(); break;
                case 2:_primaryStorage="SSD 512 GB"; _primaryStoragePrice=100;  _orderTotal=_memPrice + _processorPrice+_primaryStoragePrice; BuySecondaryStorage(); break;
                case 3:_primaryStorage="SSD 1 TB";   _primaryStoragePrice=125;  _orderTotal=_memPrice + _processorPrice+_primaryStoragePrice; BuySecondaryStorage(); break;
                case 4:_primaryStorage="SSD 2 TB";   _primaryStoragePrice=230;_orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice;  BuySecondaryStorage(); break;
               

            }
        } else
        {

            Error();
        }
    }

    private void BuySecondaryStorage ()
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine();
        Console.WriteLine("Press 1)  To buy no secondary storage for $0");
        Console.WriteLine("Press 2)  To buy HDD 1 TB for your secondary storgae for $40");
        Console.WriteLine("Press 3)  To buy HDD 2 TB for your secondary storgae for $50");
        Console.WriteLine("Press 4)  To buy HDD 4 TB for your secondary storgae for $70");
        Console.WriteLine("Press 5)  To buy SSD 512 GB for your secondary storgae for $100");
        Console.WriteLine("Press 6)  To buy SSD 1 TB for your secondary storgae for $125");
        Console.WriteLine("Press 7)  To buy SSD 2 TB for your secondary storgae for $230");

        int response = Int32.Parse(Console.ReadLine());
        if (response <= 7)
        {
            switch (response)
            {
                case 1: _secondaryStorage="No Secondary Storage"; _secondaryStoragePrice=0; _orderTotal= _memPrice + _processorPrice+_primaryStoragePrice+_secondaryStoragePrice;BuyGraphics(); break;
                case 2: _secondaryStorage=" HDD 1 TB"; _secondaryStoragePrice=40; _orderTotal=_memPrice + _processorPrice+_primaryStoragePrice+_secondaryStoragePrice; ;         BuyGraphics(); break;
                case 3: _secondaryStorage="HDD 2 TB";   _secondaryStoragePrice=50; _orderTotal=_memPrice + _processorPrice+_primaryStoragePrice+_secondaryStoragePrice;          BuyGraphics(); break;
                case 4: _secondaryStorage="HDD 4 TB";   _secondaryStoragePrice=70; _orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice;         BuyGraphics(); break;
                case 5: _secondaryStorage="SSD 512 GB"; _secondaryStoragePrice=100; _orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice;        BuyGraphics(); break;
                case 6: _secondaryStorage="SSD 1 TB"; _secondaryStoragePrice=125; _orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice;          BuyGraphics(); break;
                case 7: _secondaryStorage="SSD 2 TB"; _secondaryStoragePrice=230; _orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice;          BuyGraphics(); break;
            }
        } else
        {

            Error();
        }
    }

    private void BuyGraphics ()
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine();
        Console.WriteLine("Press 1) To buy no graphics for $0");
        Console.WriteLine("Press 2) To buy GeForce RTX 3070 for $580");
        Console.WriteLine("Press 3) To buy GeForce RTX 2070 for $400");
        Console.WriteLine("Press 4) To buy  Radeon RX 6600 $300");
        Console.WriteLine("Press 5) To buy Radeon RX 5600 for $325");
        int response = Int32.Parse(Console.ReadLine());
        if (response <= 5)
        {
            switch (response)
            {
                case 1: _graphicsName="no graphics";  _graphicsPrice=0; _orderTotal= _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice;   BuyOperating();  break;
                case 2: _graphicsName="GeForce RTX 3070"; _graphicsPrice=580; _orderTotal=_memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice; BuyOperating(); break;
                case 3: _graphicsName="GeForce RTX 2070"; _graphicsPrice=400; _orderTotal=_memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice; BuyOperating(); break;
                case 4: _graphicsName="Radeon RX 6600"; _graphicsPrice=300; _orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice; BuyOperating(); break;
                case 5: _graphicsName="Radeon RX 5600 "; _graphicsPrice=325; _orderTotal=_memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice; BuyOperating(); break;

            }
        } else
        {

            Error();
        }
    }

    private void BuyOperating ()
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine();
        Console.WriteLine("Press 1) To buy Windows 11 Home for $140");
        Console.WriteLine("Press 2) To buy Windows 11 Pro for $160");
        Console.WriteLine("Press 3) To buy Windows 10 Home for $150");
        Console.WriteLine("Press 4) To buy  Windows 10 Pro $170");
        Console.WriteLine("Press 5) To buy Linux (Fedora) for $20");
        Console.WriteLine("Press 6) To buy Linux (Red Hat) for $60");
        int response = Int32.Parse(Console.ReadLine());
        if (response <= 6)
        {
            switch (response)
            {
                case 1: _operatingName=" Windows 11 Home"; _operatingPrice=140; _orderTotal= _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; Console.WriteLine($"You have ordered a {_processorName:C2} for {_processorPrice:C2} \n You have ordered a {_memName:C2} for {_memPrice:C2}\n You have ordered a {_primaryStorage} for {_primaryStoragePrice:C2}\nYou have ordered a {_secondaryStorage} for {_secondaryStoragePrice:C2}\nYou have ordered a {_graphicsName} for {_graphicsPrice:C2}\nYou have ordered {_operatingName} for {_operatingPrice:C2} "); DisplayMenu(); break;
                case 2: _operatingName="Windows 11 Pro"; _operatingPrice=160; _orderTotal=_memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; Console.WriteLine($"You have ordered a {_processorName:C2} for {_processorPrice:C2} \n You have ordered a {_memName:C2} for {_memPrice:C2}\n You have ordered a {_primaryStorage} for {_primaryStoragePrice:C2}\nYou have ordered a {_secondaryStorage} for {_secondaryStoragePrice:C2}\nYou have ordered a {_graphicsName} for {_graphicsPrice:C2}\nYou have ordered {_operatingName} for {_operatingPrice:C2} "); DisplayMenu(); break;
                case 3: _operatingName=" Windows 10 Home"; _operatingPrice=150; _orderTotal=_memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; Console.WriteLine($"You have ordered a {_processorName:C2} for {_processorPrice:C2} \n You have ordered a {_memName:C2} for {_memPrice:C2}\n You have ordered a {_primaryStorage} for {_primaryStoragePrice:C2}\nYou have ordered a {_secondaryStorage} for {_secondaryStoragePrice:C2}\nYou have ordered a {_graphicsName} for {_graphicsPrice:C2}\nYou have ordered {_operatingName} for {_operatingPrice:C2} "); DisplayMenu(); break;
                case 4: _operatingName="Windows 10 Pro"; _operatingPrice=170; _orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; Console.WriteLine($"You have ordered a {_processorName:C2} for {_processorPrice:C2} \n You have ordered a {_memName:C2} for {_memPrice:C2}\n You have ordered a {_primaryStorage} for {_primaryStoragePrice:C2}\nYou have ordered a {_secondaryStorage} for {_secondaryStoragePrice:C2}\nYou have ordered a {_graphicsName} for {_graphicsPrice:C2}\nYou have ordered {_operatingName} for {_operatingPrice:C2} "); DisplayMenu(); break;
                case 5: _operatingName="Linux (Fedora) "; _operatingPrice=20; _orderTotal=_memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; Console.WriteLine($"You have ordered a {_processorName:C2} for {_processorPrice:C2} \n You have ordered a {_memName:C2} for {_memPrice:C2}\n You have ordered a {_primaryStorage} for {_primaryStoragePrice:C2}\nYou have ordered a {_secondaryStorage} for {_secondaryStoragePrice:C2}\nYou have ordered a {_graphicsName} for {_graphicsPrice:C2}\nYou have ordered {_operatingName} for {_operatingPrice:C2} "); DisplayMenu(); break;
                case 6: _operatingName="Linux (Red Hat) "; _operatingPrice=60; _orderTotal=_memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; Console.WriteLine($"You have ordered a {_processorName:C2} for {_processorPrice:C2} \n You have ordered a {_memName:C2} for {_memPrice:C2}\n You have ordered a {_primaryStorage} for {_primaryStoragePrice:C2}\nYou have ordered a {_secondaryStorage} for {_secondaryStoragePrice:C2}\nYou have ordered a {_graphicsName} for {_graphicsPrice:C2}\nYou have ordered {_operatingName} for {_operatingPrice:C2} "); DisplayMenu(); break;

            }
        } else
        {

            Error();
        }
    }
   

    private void DisplayOutro ()
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine();
        Console.WriteLine("Thanks for shopping!");
        Console.WriteLine("Press Enter key to exit");
        if (Console.ReadKey().Key != ConsoleKey.Enter)
        {
            
            Console.WriteLine();
            Console.Clear();
            DisplayMenu();
        } else Environment.Exit(0);

    }

    private void ViewOrder ( string itemName, decimal icost, string memoryName, decimal memoryCost, string primaryStorageTitle, decimal primaryStorageCost, string secondaryStorageTitle, decimal secondaryStorageCost, string graphicsTitle, decimal graphicsCost,string operatorTitle, decimal operatorCost, decimal cart)
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine();
        if (itemName == "")
        {
            Console.WriteLine($"There is no order yet.        Cart:{cart:C2}");
            DisplayMenu();
        } else
        {
            Console.WriteLine($"Processor: {itemName}    {icost:C2}");
            Console.WriteLine($"Memory: {memoryName}                      {memoryCost:C2}");
            Console.WriteLine($"Primary Storage: {primaryStorageTitle}       {primaryStorageCost:C2}");
            Console.WriteLine($"Secondary Storage: {secondaryStorageTitle}   {secondaryStorageCost:C2}");
            Console.WriteLine($"Graphics card: {graphicsTitle}    {graphicsCost:C2}");
            Console.WriteLine($"Operating System: {operatorTitle}  {operatorCost:C2}");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Total:                   {cart:C2}");
        }
        Console.WriteLine();
        Console.WriteLine("To return to menu press the M key");
       
        if (Console.ReadKey().Key != ConsoleKey.M)
        {
           
            Console.WriteLine("Incorrect input automatic redirection.");
          
            DisplayMenu();
            
        } else DisplayMenu();

    }

    private void ClearOrder ( string itemName, decimal icost, string memoryName, decimal memoryCost, string primaryStorageTitle, decimal primaryStorageCost, string secondaryStorageTitle, decimal secondaryStorageCost, string graphicsTitle, decimal graphicsCost, string operatorTitle, decimal operatorCost, decimal cart )
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine();
        Console.WriteLine("Are you sure you would like to clear your order.  (Y/N)");
        string response = Console.ReadLine().ToUpper();

        if (response.StartsWith("Y"))
        {
            _memName="";
            _memPrice=0m;
            _orderTotal=0m;
            _processorName="";
            _processorPrice=0m;
            _primaryStorage="";
            _primaryStoragePrice=0m;
            _secondaryStorage="";
            _secondaryStoragePrice=0m;
            _graphicsName="";
            _graphicsPrice=0m;
            _operatingName="";
            _operatingPrice=0;
            DisplayMenu();
        } else if (response.StartsWith("N"))
        {
            DisplayMenu();
        } else
        {
            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
            ClearOrder(itemName, icost, memoryName, memoryCost, primaryStorageTitle, primaryStorageCost,secondaryStorageTitle, secondaryStorageCost,graphicsTitle,graphicsCost,operatorTitle,operatorCost, cart);

        }


    }

    private void ModifyOrder ( string itemName, decimal icost, string memoryName, decimal memoryCost, string processorTitle, decimal processorCost, string secondaryStorageTitle, decimal secondaryStorageCost, string graphicsTitle, decimal graphicsCost, string operatorTitle, decimal operatorCost, decimal cart )
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine();
        
        if (itemName == "")
        {
            Console.WriteLine("There is no order to modify");
            DisplayMenu();
        } else
        {
            Console.WriteLine("Here are your current componets");
            Console.WriteLine("========================");
            Console.WriteLine($"{itemName} for {icost:C2}");
            Console.WriteLine($"{memoryName} for {memoryCost:C2}");
            Console.WriteLine($"{processorTitle} for {processorCost:C2}");
            Console.WriteLine($"{secondaryStorageTitle} for {secondaryStorageCost:C2}");
            Console.WriteLine($"{graphicsTitle} for {graphicsCost:C2}");
            Console.WriteLine($"{operatorTitle}  for {operatorCost:C2}");
            Console.WriteLine("==============");
            Console.WriteLine("Press 1)  If you would like to modify your processor");
            Console.WriteLine("Press 2)  If you would like to modify your memory");
            Console.WriteLine("Press 3) If you would like to modify your primary storage");
            Console.WriteLine("Press 4) If you would like to modify your secondary storage");
            Console.WriteLine("Press 5) If you would like to modify your graphics card");
            Console.WriteLine("Press 6) If you would like to modify your operating system");
            Console.WriteLine("Press 7) To return back to the menu");
            int response = Int32.Parse(Console.ReadLine());
            switch (response)
            {
                case 1: ModifyProcessor(); break;
                case 2: ModifyMemory(); break;
                case 3: ModifyPrimaryStorage(); break;
                case 4:ModifySecondaryStorage(); break;
                case 5: ModifyGraphics(); break;
                case 6: ModifyOperator(); break;
                case 7:  DisplayMenu(); break;

            }


        }


    }

    private void ModifyProcessor (  )
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine();
        Console.WriteLine("Press 1----- To buy the AMD Ryzen 9 5900X Processor for $1410.00");
        Console.WriteLine("Press 2----- To buy the AMD Ryzen 7 5700X Processor for $1270.00");
        Console.WriteLine("Press 3----- To buy the AMD Ryzen 5 5600X Processor for $1200.00");
        Console.WriteLine("Press 4----- To buy the Intel i9-12900K Processor for $1590.00");
        Console.WriteLine("Press 5----- To buy the Intel i7-12700K Processor for $1400.00");
        Console.WriteLine("Press 6----- To buy the Intel i5-12600K Processor for $1280.00");
        Console.WriteLine("Press 7) To return back to the menu");
        int response = Int32.Parse(Console.ReadLine());
        try
        {
            switch (response)
            {
                case 1: _processorName="AMD Ryzen 9 5900X"; _processorPrice=1410; _orderTotal=_processorPrice + _memPrice +_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage,_primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 2: _processorName="AMD Ryzen 7 5700X"; _processorPrice=1270; _orderTotal=_processorPrice + _memPrice +_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage,_primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 3: _processorName="AMD Ryzen 5 5600X"; _processorPrice=1200; _orderTotal=_processorPrice + _memPrice +_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage,_primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 4: _processorName="Intel i9-12900K"; _processorPrice=1590; _orderTotal=_processorPrice + _memPrice +_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ;   ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage,_primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal);  break;
                case 5: _processorName="Intel i7-12700K"; _processorPrice=1400; _orderTotal=_processorPrice + _memPrice +_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ;   ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage,_primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 6: _processorName="Intel i5-12600K"; _processorPrice=1200; _orderTotal=_processorPrice + _memPrice +_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ;   ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage,_primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 7: DisplayMenu(); break;
                default: Error(); break;
            }
        } catch (FormatException)
        {

            Error();
        }
    }

    private void ModifyMemory ()
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine();
        Console.WriteLine("Press 1----- To buy 8 GB of memory for $30");
        Console.WriteLine("Press 2----- To buy 16 GB of memory for $40");
        Console.WriteLine("Press 3----- To buy 32 GB of memory for $90");
        Console.WriteLine("Press 4----- To buy 64 GB for memory $410");
        Console.WriteLine("Press 5----- To buy 128 GB of memory for $600");
        Console.WriteLine("Press 6) To return back to the menu");
        int response = Int32.Parse(Console.ReadLine());
        
        if (response <= 6)
        {
            
            switch (response)
            {
                case 1: _memName="8 GB"; _memPrice=30; _orderTotal= _memPrice + _processorPrice +_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice,    _primaryStorage,_primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 2: _memName="16 GB"; _memPrice=40; _orderTotal=_memPrice + _processorPrice +_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice,    _primaryStorage,_primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 3: _memName="32 GB"; _memPrice=90; _orderTotal=_memPrice + _processorPrice +_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice,    _primaryStorage,_primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 4: _memName="64 GB"; _memPrice=410; _orderTotal = _memPrice + _processorPrice +_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage,_primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 5: _memName="128 GB"; _memPrice=600; _orderTotal=_memPrice + _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice,  _primaryStorage,_primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 6: DisplayMenu(); break;
               

            }
        } else
        {

            Error();
        }
    }

    private void ModifyPrimaryStorage ()
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine();
        Console.WriteLine("Press 1)    To buy SSD 356 GB for your primary storage for $90");
        Console.WriteLine("Press 2)    To buy SSD 512 GB for your primary storage for $100");
        Console.WriteLine("Press 3)     To buy SSD 1 TB for your primary storage for $125");
        Console.WriteLine("Press 4)    To buy SSD 2 TB for your primary storage for $230");
        Console.WriteLine("Press 5) To return back to the menu");

        int response = Int32.Parse(Console.ReadLine());
        if (response <= 5)
        {
            switch (response)
            {
                case 1: _primaryStorage="SSD 356 GB"; _primaryStoragePrice=90; _orderTotal= _memPrice + _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage,_primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 2: _primaryStorage="SSD 512 GB"; _primaryStoragePrice=100; _orderTotal=_memPrice + _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage,_primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 3: _primaryStorage="SSD 1 TB"; _primaryStoragePrice=125; _orderTotal=_memPrice + _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ;   ModifyOrder(_processorName, _processorPrice, _memName, _memPrice,   _primaryStorage,_primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 4: _primaryStorage="SSD 2 TB"; _primaryStoragePrice=230; _orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ;  ModifyOrder(_processorName, _processorPrice, _memName, _memPrice,  _primaryStorage,_primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 5: DisplayMenu(); break;


            }
        } else
        {

            Error();
        }
    }

    private void ModifySecondaryStorage ()
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine();
        Console.WriteLine("Press 1)    To buy no secondary storage for $0");
        Console.WriteLine("Press 2)    To buy HDD 1 TB for your secondary storage for $40");
        Console.WriteLine("Press 3)    To buy HDD 2 TB for your secondary storage for $50");
        Console.WriteLine("Press 4)    To buy HDD 4 TB for your secondary storage for $70");
        Console.WriteLine("Press 5)    To buy SSD 512 GB for your secondary storage for $100");
        Console.WriteLine("Press 6)    To buy SSD 1 TB for your secondary storage for $125");
        Console.WriteLine("Press 7)    To buy SSD 2 TB for your secondary storage for $230");
        Console.WriteLine("Press 8) To return back to the menu");

        int response = Int32.Parse(Console.ReadLine());
        if (response <= 8)
        {
            switch (response)
            {  
                case 1: _secondaryStorage="No secodary storage"; _secondaryStoragePrice=0; _orderTotal= _memPrice + _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 2: _secondaryStorage=" HDD 1 TB"; _secondaryStoragePrice=40; _orderTotal=_memPrice + _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 3: _secondaryStorage="HDD 2 TB"; _secondaryStoragePrice=50; _orderTotal=_memPrice + _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 4: _secondaryStorage="HDD 4 TB"; _secondaryStoragePrice=70; _orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 5: _secondaryStorage="SSD 512 GB"; _secondaryStoragePrice=100; _orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 6: _secondaryStorage="SSD 1 TB"; _secondaryStoragePrice=125; _orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal);  break;
                case 7: _secondaryStorage="SSD 2 TB"; _secondaryStoragePrice=230; _orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal);  break;
                case 8: DisplayMenu(); break;
            }
        } else
        {

            Error();
        }
    }

    private void ModifyGraphics ()
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine();
        Console.WriteLine("Press 1) To buy no graphics for $0");
        Console.WriteLine("Press 2) To buy GeForce RTX 3070 for $580");
        Console.WriteLine("Press 3) To buy GeForce RTX 2070 for $400");
        Console.WriteLine("Press 4) To buy  Radeon RX 6600 $300");
        Console.WriteLine("Press 5) To buy Radeon RX 5600 for $325");
        Console.WriteLine("Press 6) To return back to the menu");

        int response = Int32.Parse(Console.ReadLine());
        if (response <= 6)
        {
            switch (response)
            {
                case 1: _graphicsName="No graphics card"; _graphicsPrice=0; _orderTotal= _memPrice + _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 2: _graphicsName="GeForce RTX 3070"; _graphicsPrice=580; _orderTotal=_memPrice + _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 3: _graphicsName="GeForce RTX 2070"; _graphicsPrice=400; _orderTotal=_memPrice + _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 4: _graphicsName=" Radeon RX 6600";  _graphicsPrice=300; _orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 5: _graphicsName="Radeon RX 5600";   _graphicsPrice=325; _orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 6: DisplayMenu(); break;
            }
        } else
        {

            Error();
        }
    }

    private void ModifyOperator ()
    {
        Console.Clear();
        Console.WriteLine($"Your current cart total is: {_orderTotal:C2}");
        Console.WriteLine();
        Console.WriteLine("Press 1) To buy Windows 11 Home for $140");
        Console.WriteLine("Press 2) To buy Windows 11 Pro for $160");
        Console.WriteLine("Press 3) To buy Windows 10 Home for $150");
        Console.WriteLine("Press 4) To buy  Windows 10 Pro $170");
        Console.WriteLine("Press 5) To buy Linux (Fedora) for $20");
        Console.WriteLine("Press 6) To buy Linux (Red Hat) for $60");
        Console.WriteLine("Press 7) To return back to the menu");

        int response = Int32.Parse(Console.ReadLine());
        if (response <= 7)
        {
            switch (response)
            {
                case 1: _operatingName="Windows 11 Home"; _operatingPrice=140; _orderTotal= _memPrice + _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 2: _operatingName="Windows 11 Pro"; _operatingPrice=160; _orderTotal=_memPrice + _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 3: _operatingName="Windows 10 Home"; _operatingPrice=150; _orderTotal=_memPrice + _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 4: _operatingName=" Windows 10 Pro";  _operatingPrice=170; _orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 5: _operatingName="Linux (Fedora)"; _operatingPrice=20; _orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 6: _operatingName="Linux (Red Hat)"; _operatingPrice=60; _orderTotal = _memPrice+ _processorPrice+_primaryStoragePrice+_secondaryStoragePrice+_graphicsPrice+_operatingPrice; ModifyOrder(_processorName, _processorPrice, _memName, _memPrice, _primaryStorage, _primaryStoragePrice, _secondaryStorage, _secondaryStoragePrice, _graphicsName, _graphicsPrice, _operatingName, _operatingPrice, _orderTotal); break;
                case 7: DisplayMenu(); break;
            }
        } else
        {

            Error();
        }
    }
    private void Error ()
    {
        Console.Clear();
        _orderTotal = 0;
        Console.WriteLine("Youv have entered an incorrect input, restarting order");
        DisplayMenu();
    }

    private void PurchaseError ( string itemName,  string memoryName, string processorTitle,  string secondaryStorageTitle,  string graphicsTitle,  string operatorTitle  )
    {
        if ( itemName == "")
        {
            BuyProcessor();
        }
        else if ( memoryName == "")
        {
            BuyMemory();
        }
        else if(processorTitle == "")
        {
            BuyPrimaryStorage();

        }
        else if(secondaryStorageTitle == "")
        {
            BuySecondaryStorage();
        }
        else if(graphicsTitle == "")
        {
            BuyGraphics();
        }
        else if(operatorTitle == "")
        {
            BuyOperating();
        }

    }
}
