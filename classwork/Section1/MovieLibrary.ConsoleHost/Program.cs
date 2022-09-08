//Movie defintion
/*
 * int32.Parse(string)--> int
 * int32.TryParse(string)--> boolean
 * Error checking
 * Logical operatores
 *  AND/OR/NOT
 *  AND: T/T equals true T/F equals False FF equales F                                                                                                                                                                                                                                     
 *  
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */
string title = "";
string description = "";
int runLength = 0; //In minutes
int releaseYear = 1900;
string rating = "";
bool isClassic = false;

AddMovie();

bool ReadBoolean ( string message )
{
    Console.Write(message);

    //Looking for Y/N
    ConsoleKeyInfo key = Console.ReadKey();
    if (key.Key == ConsoleKey.Y)
        return true;
    else if (key.Key == ConsoleKey.N)
        return false;

    //TODO:error
    return false;
}

int ReadInt32 ( string message, int minimumValue, int maximumValue )
{
    Console.Write(message); //prompts the user

    do
    {
        string value = Console.ReadLine(); //reads the users input and store it into value

        //in line variable declaration
        if (Int32.TryParse(value, out int result))
        {
            if (result >= minimumValue && result <= maximumValue)
                return result;
        };
        //int result;
        // if(Int32.TryParse(value, out result))

        Console.WriteLine("value must be between " + minimumValue + " and " + maximumValue);

    } while (true);
    
}


string ReadString ( string message, bool required )
{
    Console.Write(message);

    while (true)
    {


        string value = Console.ReadLine();

        // check if required
        if (value != "" || !required)
            return value;

        //value is not empty 
        //value is empty and required
        Console.WriteLine("Value is required");

    };
}

void AddMovie ()
{
    //string title
    title = ReadString("Enter a title: ", true);

    description=ReadString("Enter a optional description: ", false);

    runLength = ReadInt32("Enter a run length (in minutes): ", 0 , 300);

    releaseYear = ReadInt32("Enter the release year: ", 1900 , 2100);

    rating = ReadString("Enter MPAA rating: ", true);

    isClassic = ReadBoolean("is this a classic? ");


}

