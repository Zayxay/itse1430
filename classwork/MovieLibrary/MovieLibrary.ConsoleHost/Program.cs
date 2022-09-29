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
using System;

using MovieLibrary;

 // movie does not hold the value but holds the reference to the movie data





DisplayInformation();
Movie movie = null;
MovieDatabase database = new MovieDatabase();
bool done = false;
do
{
    //MenuOption input = DisplayMenu();
    var input = DisplayMenu();
    Console.WriteLine();
    switch (input)
    {

        case MenuOption.Add:
        {
            var theMovie = AddMovie();
            movie = theMovie.Clone();
            break;
        }
        case MenuOption.Edit: EditMovie(); break;
        case MenuOption.View: ViewMovie(movie);  break;
        case MenuOption.Delete: break;
        case MenuOption.Quit: done = true; break;
    }
    //if (input == 'A')
    //    AddMovie();
    //else if (input == 'E')
    //    EditMovie();
    //else if (input == 'V')
    //    ViewMovie();
    //else if (input == 'D')
    //    DeleteMovie();
    //else if (input == 'Q')
    //    break;
} while (!done);



//Functions


void DisplayInformation ()
{
    Console.WriteLine("Movie Libary");
    Console.WriteLine("David-Isaiah");
    Console.WriteLine("Fall 2022");
}
MenuOption DisplayMenu ()
{
    Console.WriteLine();
    Console.WriteLine("---------");
    Console.WriteLine("".PadLeft(10, '-'));
    Console.WriteLine("A)dd Movie");
    Console.WriteLine("E)dit Movie");
    Console.WriteLine("V)iew Movie");
    Console.WriteLine("D)elete Movie");
    Console.WriteLine("Q)uit");

    do
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.A: return MenuOption.Add;
            case ConsoleKey.E: return MenuOption.Edit;
            case ConsoleKey.V: return MenuOption.View;
            case ConsoleKey.D: return MenuOption.Delete;
            case ConsoleKey.Q: return MenuOption.Quit;

        };
    } while (true);

    //    if (key.Key == ConsoleKey.A)
    //        return 'A';
    //    else if (key.Key == ConsoleKey.E)
    //        return 'E';
    //    else if (key.Key == ConsoleKey.V)
    //        return 'V';
    //    else if (key.Key == ConsoleKey.D)
    //        return 'D';
    //    else if (key.Key == ConsoleKey.Q)
    //        return 'Q';
    //} while (true);
}

bool ReadBoolean ( string message )
{
    Console.Write(message);

    //Looking for Y/N
    do
    {
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.Y)
            return true;
        else if (key.Key == ConsoleKey.N)
            return false;
    } while (true);
    //TODO:error

}

int ReadInt32 ( string message, int minimumValue, int maximumValue )
{
    Console.Write(message); //prompts the user

    do
    {
        string value = Console.ReadLine(); //reads the users input and store it into value

        //in line variable declaration

        //if (Int32.TryParse(value, out int result))
        if (Int32.TryParse(value, out var result))
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

Movie AddMovie ()
{
    Movie movie = new Movie ("Title");
    //string title
    //movie.title = ReadString("Enter a title: ", true);
    //movie.SetTitle(ReadString("Enter a title: ", true));
    movie.Title = ReadString("Enter a title: ", true);


    movie.Description=ReadString("Enter a optional description: ", false);
    
    movie.RunLength = ReadInt32("Enter a run length (in minutes): ", 0, 300);
    
    movie.ReleaseYear = ReadInt32("Enter the release year: ", 1900, 2100);

    if (movie.ReleaseYear >= Movie.YearColorWasIntroduced)
        Console.WriteLine("Old movie");

    //var emptyMovie = Movie.Empty;
    
    movie.Rating = ReadString("Enter MPAA rating: ", true);
    
    movie.IsClassic = ReadBoolean("is this a classic? ");

    
    return movie;
}

Movie GetSelectedMovie ()
{
    var item = database.Get(0);
    return movie;
}
void EditMovie ()
{

}

void DeleteMovie ()
{
    //No Movie
    var selectedMovie = GetSelectedMovie();
    if (selectedMovie==null)
        return;
    //Not cconfirmed
    if (!ReadBoolean($"Are you sure you want to delete the movie '{selectedMovie.Title}' (Y/N)? "))
        return;
    //TODO: Delete Movie
    movie=null ;


}

void ViewMovie (Movie movie)
{
    if (movie==null)
    {
        Console.WriteLine("No movies available");
        return;
    }

    Console.WriteLine($"{movie.Title} ({movie.ReleaseYear})");
    //String formating concatination
    //Opton 1 - Concatination
    //Console.WriteLine("Length:" + runLength + "mins");


    //option 2 -String.Format
    //Console.WriteLine("Length:" + runLength + "mins");
    //Console.WriteLine(String.Format("Length: {0} mins", runLength));
    Console.WriteLine("Length: {0} mins", movie.RunLength);

    //Optio 3 - String Interpulation
    Console.WriteLine($"Length: {movie.RunLength} mins");
    //Console.WriteLine(releaseYear);
    //ToString
    Console.WriteLine(movie.ReleaseYear.ToString());
    //Console.WriteLine("Length:" + runLength + "mins");
    Console.WriteLine($"Ratied {movie.Rating}");
    Console.WriteLine($" Is Classic: {(movie.IsClassic ? "Yes" : "No")}");
    Console.WriteLine(movie.Description);
    var blackAndWhite = movie.IsBlackAndWhite;
    //movie.IsBlackAndWhite = true;
}

