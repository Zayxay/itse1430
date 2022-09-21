//decimal cartValue = 0m;
//string str = "";
//string pad = str.PadLeft(10, '-');
//Console.Title = "PC Builder";


////Calling
//DisplayInformation();
//var done = false;

//do
//{
//    var input = DisplayMenu();
//    switch (input)
//    {
//        case MenuOption.NewOrder: NewOrder(); break;
//        case MenuOption.Quit: done= true; break;
//    };


//} while (!done);



////Functions

//void DisplayInformation ()
//{
//    Console.WriteLine("David-Isaiah Ngouambeu");
//    Console.WriteLine("ITSE 1430");
//    Console.WriteLine("09/15/2022");
//    Console.WriteLine(pad);

//}

//MenuOption DisplayMenu ()
//{
//    Console.WriteLine($"CART: {cartValue} "); //TODO
//    Console.WriteLine("N)ew Order");
//    Console.WriteLine("Q)uit");
//    Console.WriteLine(pad);

//    do
//    {
//        ConsoleKeyInfo key = Console.ReadKey(true);
//        switch (key.Key)
//        {
//            case ConsoleKey.N: return MenuOption.NewOrder;
//            case ConsoleKey.Q: return MenuOption.Quit;
//        };

//    } while (true);
//}

//void NewOrder ()
//{
//    Console.WriteLine("CART: " + cartValue);
//    Console.WriteLine("");
//    Console.WriteLine($"Choose A Processor ");
//    Console.WriteLine($"1) AMD Ryzen 9 5900X ---- $1410");
//    Console.WriteLine($"2) AMD Ryzen 7 5700Xd ---- $1270");
//    Console.WriteLine($"3) AMD Ryzen 5 5600Xd ---- $1200");
//    Console.WriteLine($"4) Intel i9-12900K ----- $1590");
//    Console.WriteLine($"5) Intel i7-12700K ---- $1400");
//    Console.WriteLine($"6) Intel i5-12600K ---- $1280");
//    Console.WriteLine($"{pad}");
//    int option = int.Parse(Console.ReadLine());

//    do
//    {
//        switch (option)
//        {
//            case 1: FirstProcessor(); break;
//            case 2: SecondProcessor(); break;
//            case 3: ThirdProcessor(); break;
//            case 4: FourthProcessor(); break;
//            case 5: FifthProcessor(); break;
//            case 6: SixthProcessor(); break;
//            default:
//            {
//                Console.WriteLine("Invalid entry. Please re enter choice");
//                Console.Clear();
//                DisplayMenu();
//                break;
//            }

//        }
//    } while (!true);




//}

//void FirstProcessor ()
//{
//    Console.Clear();
//    Console.WriteLine("Cart: " + (cartValue + 1400));
//    Console.WriteLine(pad);
//    Console.WriteLine("CHOOSE MEMORY");
//    Console.WriteLine(pad);
//    Console.WriteLine($"1) 8 GB --- $30 ");
//    Console.WriteLine($"2) 16 GB ---- $40");
//    Console.WriteLine($"3) 32 GB ---- $90");
//    Console.WriteLine($"4) 64 GB ---- $410");
//    Console.WriteLine($"5) 128 GB  ---- $600");


//}

//void SecondProcessor ()
//{
//    Console.WriteLine("Cart: " + (cartValue + 1270));

//    Console.WriteLine(pad);

//    Console.WriteLine("CHOOSE MEMORY");
//    Console.WriteLine(pad);
//    Console.WriteLine($"1) 8 GB --- $30 ");
//    Console.WriteLine($"2) 16 GB ---- $40");
//    Console.WriteLine($"3) 32 GB ---- $90");
//    Console.WriteLine($"4) 64 GB ---- $410");
//    Console.WriteLine($"5) 128 GB  ---- $600");
//}

//void ThirdProcessor ()
//{
//    Console.WriteLine("Cart: " + (cartValue + 1200));
//    Console.WriteLine("CHOOSE MEMORY");
//    Console.WriteLine(pad);
//    Console.WriteLine($"1) 8 GB --- $30 ");
//    Console.WriteLine($"2) 16 GB ---- $40");
//    Console.WriteLine($"3) 32 GB ---- $90");
//    Console.WriteLine($"4) 64 GB ---- $410");
//    Console.WriteLine($"5) 128 GB  ---- $600");
//}

//void FourthProcessor ()
//{
//    Console.WriteLine("Cart: " + (cartValue + 1590));


//    Console.WriteLine(pad);
//    Console.WriteLine("CHOOSE MEMORY");
//    Console.WriteLine(pad);
//    Console.WriteLine($"1) 8 GB --- $30 ");
//    Console.WriteLine($"2) 16 GB ---- $40");
//    Console.WriteLine($"3) 32 GB ---- $90");
//    Console.WriteLine($"4) 64 GB ---- $410");
//    Console.WriteLine($"5) 128 GB  ---- $600");
//}

//void FifthProcessor ()
//{
//    Console.WriteLine("Cart: " + (cartValue + 1400));


//    Console.WriteLine(pad);
//    Console.WriteLine("CHOOSE MEMORY");
//    Console.WriteLine(pad);
//    Console.WriteLine($"1) 8 GB --- $30 ");
//    Console.WriteLine($"2) 16 GB ---- $40");
//    Console.WriteLine($"3) 32 GB ---- $90");
//    Console.WriteLine($"4) 64 GB ---- $410");
//    Console.WriteLine($"5) 128 GB  ---- $600");
//}

//void SixthProcessor ()
//{
//    Console.WriteLine("Cart: " + (cartValue + 1280));

//    Console.WriteLine("");

//    Console.WriteLine("CHOOSE MEMORY");
//    Console.WriteLine(pad);
//    Console.WriteLine($"1) 8 GB --- $30 ");
//    Console.WriteLine($"2) 16 GB ---- $40");
//    Console.WriteLine($"3) 32 GB ---- $90");
//    Console.WriteLine($"4) 64 GB ---- $410");
//    Console.WriteLine($"5) 128 GB  ---- $600");
//}

//decimal cartValue = 0m;
//string str = "";
//string pad = str.PadLeft(10, '-');
//Console.Title = "PC Builder";

////Calling
//DisplayInformation();
//MenuDisplay();
////functions

//void DisplayInformation ()
//{
//    Console.WriteLine("David-Isaiah Ngouambeu");
//    Console.WriteLine("ITSE 1430");
//    Console.WriteLine("09/15/2022");
//    Console.WriteLine(pad);

//}

//void MenuDisplay ()
//{
//    //Console.Clear();
//    Console.WriteLine($"CART: {cartValue}");
//    Console.WriteLine(pad);
//    Console.WriteLine("PLEASE TYPE AN OPTION NUMBER");
//    Console.WriteLine("");
//    Console.WriteLine("Option 1. New Order");
//    Console.WriteLine("Option 2. Quit");

//    int myOptions;
//    myOptions = Int32.Parse(Console.ReadLine());
//    switch (myOptions)
//    {
//        case 1: NewOrder(); break;
//        case 2: Quit(); break;
//        default: Error(); break;
//    }
//    MenuDisplay();


//}



//void Quit ()
//{
//    Console.WriteLine("");
//    Console.WriteLine();
//    Console.WriteLine("ARE YOU SURE YOU WOULD LIKE TO EXIT? Y/N");
//    ConsoleKeyInfo key = Console.ReadKey();
//    switch (key.Key)
//    {
//        case ConsoleKey.Y :  break;
//        case ConsoleKey.N : Console.WriteLine("");  MenuDisplay(); break;
//    }
//    Environment.Exit(0);

//}

//void NewOrder ()
//{
//    cartValue = 0;
//    Console.WriteLine($"Cart: {cartValue}");
//    Console.WriteLine("");
//    Console.WriteLine("CHOOSE A PROCESSOR NUMBER");
//    Console.WriteLine("");
//    Console.WriteLine($"NUMBER 1. AMD Ryzen 9 5900X ---- $1410");
//    Console.WriteLine($"NUMBER 2. AMD Ryzen 7 5700Xd ---- $1270");
//    Console.WriteLine($"NUMBER 3. AMD Ryzen 5 5600Xd ---- $1200");
//    Console.WriteLine($"NUMBER 4. Intel i9-12900K ----- $1590");
//    Console.WriteLine($"NUMBER 5. Intel i7-12700K ---- $1400");
//    Console.WriteLine($"NUMBER 6. Intel i5-12600K ---- $1280");
//    int number = Int32.Parse(Console.ReadLine());
//    switch (number)
//    {
//        case 1: FirstProcessor(); break;

//    }

//}

//void FirstProcessor ()
//{
//    cartValue = 1410;
//    Console.WriteLine($"CART: {cartValue}");
//    Console.WriteLine("");
//    Console.WriteLine("CHOOSE MEMORY SIZE");
//    Console.WriteLine(pad);
//    Console.WriteLine($"1. 8 GB --- $30 ");
//    Console.WriteLine($"2. 16 GB ---- $40");
//    Console.WriteLine($"3. 32 GB ---- $90");
//    Console.WriteLine($"4. 64 GB ---- $410");
//    Console.WriteLine($"5. 128 GB  ---- $600");

//}

//void Error ()
//{
//    Console.Clear();
//    Console.WriteLine("INVALID ENTRY. PLEASE TRY AGAIN: ");
//    MenuDisplay();
//}