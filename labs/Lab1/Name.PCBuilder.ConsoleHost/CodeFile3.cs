using System;
class Shop
{
    private decimal OrderTotal;

    public Shop ()
    {
        OrderTotal = 0;
    }

    public void Run ()
    {
        DisplayInfo();
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

    private void Displaymenu ()
    {

    }
    private void SellItem (string itemName, decimal icost)
    {
        Console.WriteLine($"Would you like to buy {itemName} for {icost:C2}? (y/n)");
        string response = Console.ReadLine().ToUpper();
        try
        {
            if (response.StartsWith("Y"))
            {
                decimal total = icost;
                OrderTotal += total;
                SellMemory("8GB", 30m);
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("INCORRECT INPUT...PLEASE TRY AGAIN");
            SellItem(itemName, icost);
            return;
        }
    }

    private void SellMemory(string memName, decimal mcost )
    {
        Console.WriteLine($"Your cart total is {OrderTotal}");
        Console.WriteLine($"Would you like to buy {memName} for {mcost:C2}? (y/n)");
        string response = Console.ReadLine().ToUpper();
        if (response.StartsWith("Y"))
        {
            OrderTotal += mcost;
            Console.WriteLine($"Your cart total is {OrderTotal}");
            Displaymenu();
        }

    }
    private void DisplayOrderTotal ()
    {
        Console.WriteLine($"Your current order total is: {OrderTotal:C2}. ");
    }

    private void DisplayOutro ()
    {
        Console.WriteLine("Thanks for shopping!");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey (); 
    }
}