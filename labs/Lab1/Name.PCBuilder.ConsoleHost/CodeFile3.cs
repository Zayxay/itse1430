using System;
class Shop
{
    public void Run ()
    {
        DisplayMenu();
        DisplayOutro();
    }

    private void DisplayMenu ()
    {
        Console.WriteLine("David-Isaiah Ngouambeu");
        Console.WriteLine("ITSE 1430");
        Console.WriteLine("09/15/2022");
    }

    private void SellItem ()
    {

    }

    private void DisplayOrderTotal ()
    {

    }

    private void DisplayOutro ()
    {
        Console.WriteLine("Thanks for shopping!");
        Console.WriteLine("Press any key to exit");
        Console.ReadKey (); 
    }
}