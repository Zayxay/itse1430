﻿using MovieLibrary;

DisplayInformation();

Movie movie = null;
MovieDatabase database = new MovieDatabase();

var done = false;  //bool done = false;
do
{
    //Type inferencing - compiler figures out type based upon context    
    var input = DisplayMenu();   //MenuOption input = DisplayMenu();
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
        case MenuOption.View: ViewMovie(movie); break;
        case MenuOption.Delete: DeleteMovie(); break;
        case MenuOption.Quit: done = true; break;
    };
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

/// Functions
/// 

void DisplayInformation ()
{
    Console.WriteLine("Movie Library");
    Console.WriteLine("ITSE 1430 Sample");
    Console.WriteLine("Fall 2022");
}

MenuOption DisplayMenu ()
{
    Console.WriteLine();
    //Console.WriteLine("------------");
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

        //if (key.Key == ConsoleKey.A)
        //    return 'A';
        //else if (key.Key == ConsoleKey.E)
        //    return 'E';
        //else if (key.Key == ConsoleKey.V)
        //    return 'V';
        //else if (key.Key == ConsoleKey.D)
        //    return 'D';
        //else if (key.Key == ConsoleKey.Q)
        //    return 'Q';
    } while (true);
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
}

int ReadInt32 ( string message, int minimumValue, int maximumValue )
{
    Console.Write(message);

    do
    {
        string value = Console.ReadLine();

        //Inline variable declarations    
        //int result;
        //if (Int32.TryParse(value, out result))
        //if (Int32.TryParse(value, out int result))
        if (Int32.TryParse(value, out var result))
        {
            if (result >= minimumValue && result <= maximumValue)
                return result;
        };

        //Int32.MinValue;
        //Int32.MaxValue;

        //if (false)
        //break;  //Exit loop
        //continue; //Exit iteration

        Console.WriteLine("Value must be between " + minimumValue + " and " + maximumValue);
    } while (true);
}

string ReadString ( string message, bool required )
{
    //message = "Bob";
    Console.Write(message);

    while (true)
    {
        string value = Console.ReadLine();

        //if value is not empty or not required
        if (value != "" || !required)
            return value;

        // Value is empty and required
        Console.WriteLine("Value is required");
    };
}

Movie AddMovie ()
{
    Movie movie = new Movie("Title");
    //movie = new Movie();
    //movie.Title = "Title";

    //string title = "";
    //movie.title = ReadString("Enter a title: ", true);
    //movie.SetTitle(ReadString("Enter a title: ", true));
    movie.Title = ReadString("Enter a title: ", true);

    //string description = "";
    movie.Description = ReadString("Enter an optional description: ", false);

    //var description = movie._description;
    //var description = movie.GetDescription();

    //int runLength = 0; //in minutes
    movie.RunLength = ReadInt32("Enter a run length (in minutes): ", 0, 300);

    movie.ReleaseYear = ReadInt32("Enter the release year: ", 1900, 2100);
    if (movie.ReleaseYear >= Movie.YearColorWasIntroduced)
        Console.WriteLine("Wow that is an old movie");

    //var emptyMovie = Movie.Empty.Title;    
    movie.Rating = ReadString("Entering MPAA rating: ", true);

    movie.IsClassic = ReadBoolean("Is this a classic? ");

    return movie;
}

Movie GetSelectedMovie ()
{
    //HACK: For now
    var item = database.Get(0);

    //object obj = "Hello";
    //obj = 10;
    //obj = 4.15;
    //obj.ToString();

    return movie;
}

void DeleteMovie ()
{
    var selectedMovie = GetSelectedMovie();

    //No movie
    if (selectedMovie == null)
        return;

    //Not confirmed
    if (!ReadBoolean($"Are you sure you want to delete the movie '{selectedMovie.Title}' (Y/N)? "))
        return;

    //TODO: Delete movie
    movie = null;
}

void EditMovie ()
{ }

void ViewMovie ( Movie movie )
{
    if (movie == null)
    {
        Console.WriteLine("No movies available");
        return;
    };

    //String formatting
    // Option 1 - concatenation
    // Console.WriteLine("Length: " + runLength + " mins");

    // Option 2 - String.Format
    // Console.WriteLine(String.Format("Length: {0} mins", runLength));

    // Option 3 - String interpolation
    // Console.WriteLine($"Length: {runLength} mins");
    //string someValue = $"Length = {runLength}";

    //ToString
    //Console.WriteLine($"{movie.title} ({movie.ReleaseYear})");
    Console.WriteLine($"{movie.Title} ({movie.ReleaseYear})");
    //Console.WriteLine(releaseYear);
    //Console.WriteLine(releaseYear.ToString());

    //Console.WriteLine("Length: " + runLength + " mins");
    //Console.WriteLine(String.Format("Length: {0} mins", runLength));
    //Console.WriteLine("Length: {0} mins", runLength);
    Console.WriteLine($"Length: {movie.RunLength} mins");

    Console.WriteLine($"Rated {movie.Rating}");
    //Console.WriteLine($"This {(isClassic ? "Is" : "Is Not")} a Classic");
    Console.WriteLine($"Is Classic: {(movie.IsClassic ? "Yes" : "No")}");
    Console.WriteLine(movie.Description);

    var blackAndWhite = movie.IsBlackAndWhite;
    //movie.IsBlackAndWhite = true;
}

void DisplayObject ( object sender )
{
    int intValue = 10;

    //Type casting & checking    
    // 1. C-Style cast  (T)E
    //    Must be a valid cast
    //    Blows up at runtime if fails
    string str = (string)sender;
    //str = (string)intValue;

    // 2. Type checking using is ::= E is T
    //      True if valid or false otherwise
    //      Not valid on primitives (other than string)
    if (sender is string)
    {
        //Do something
        str = (string)sender;
    };

    // 3. Safe type cast using as ::= E as T
    //      Converts to T if valid or null otherwise
    //      Doesn't work with primitives (except string)
    str = sender as string;
    if (str != null) { };

    // 4. Pattern matching  ::= E is T id
    //      Assigns typed E to id and returns true
    //      Works with any type
    if (sender is string str1)
    {
    };

    // 5. Convert.ChangeType - DON'T USE THIS
    //           .ToInt32() - DON'T USE THIS

    // Null
    //   Default value for class types
    //   Member access crashes if instance is null 
    // 1. == or != null
    // 2. conditional operator
    //str.ToString();
    if (str != null)
    {
        var str2 = str.ToString();
    };
    var str3 = (str != null) ? str.ToString() : "";

    // 3. Null coalescing ::= E ?? E
    str3 = str ?? "";  // str ?? str2 ?? str3 ?? "";

    // 4. Null conditional ::=  instance?.member
    //       (str != null) ? str.ToString() : null;
    str3 = str?.ToString();

    Movie m1 = new Movie(), m2 = new Movie();
    var areEqual = m1 == m2;

    //Point pt1 = new Point(10, 10);
    //Point pt2 = new Point(10, 10);
    //areEqual = pt1 == pt2;
}