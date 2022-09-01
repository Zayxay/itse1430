//Movie defintion
string title = "";
string description = "";
int runLength = 0; //In minutes
int releaseYear = 1900;
string rating = "";
bool isClassic = false;

AddMovie();

int ReadInt32 ( string message )
{
    Console.Write(message);
    string value = Console.ReadLine();

    //in line variable declaration
    if (Int32.TryParse(value, out int result))
        return result;

    //int result;
    // if(Int32.TryParse(value, out result))
    // return results;

    return -1;
}


string ReadString ( string message )
{
    Console.Write(message);
    string value = Console.ReadLine();
    return value;
}

void AddMovie (  )
{
    //string title
    title = ReadString("Enter a title: ");


    description=ReadString("Enter a optional description: ");


    runLength = ReadInt32("Enter a run length (in minutes): ");


    releaseYear = ReadInt32("Enter the release year: ");
    rating = ReadString("Enter MPAA rating: ");

    Console.WriteLine("Is this a classic? ");
}