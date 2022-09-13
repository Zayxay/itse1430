int hours;

Console.WriteLine("Hours: ");
string value = Console.ReadLine();

hours = Int32.Parse(value);
Console.WriteLine("Pay Rate: ");
value = Console.ReadLine();

double payRate = Double.Parse(value);

Console.WriteLine("Your pay is" + (hours * payRate));

double distanceFromMoon;
bool isPassing;
//Block statemtment
{
//    decimal payRate;
}
{
//    decimal payRate;
}

distanceFromMoon=10.5;
isPassing= distanceFromMoon>10;
//string firstName, lastName;

//String

string emptyString = "";
string emptyString2 = String.Empty;
string nullString = null;
bool isEmptyString = (emptyString == null) || (emptyString == ""); 
isEmptyString = String.IsNullOrEmpty(emptyString);

string someString = "Hello \"World";
string filePath = "C:\\windows\\system32";

filePath = @"C:\windows\system32"; /*Verbatim string*/
