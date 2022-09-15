using System;

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
string firstName = "";
string lastName = "";
string emptyString = "";
string emptyString2 = String.Empty;
string nullString = null;
bool isEmptyString = (emptyString == null) || (emptyString == ""); 
isEmptyString = String.IsNullOrEmpty(emptyString);

string someString = "Hello \"World";
string filePath = "C:\\windows\\system32";

filePath = @"C:\windows\system32"; /*Verbatim string*/

//concatonation

string fullName = "Bob" + " " + "Smith";
fullName = String.Concat("Bob", " ", "Smith");
string someValues = String.Concat("You are ", 10, "years old", true);
string names = String.Join(",", "Bob", "Sue");

int stringLength = fullName.Length;
isEmptyString = fullName.Length == 0; //checks for an empty string

//Manipulation
string upperName = fullName.ToUpper();
string lowerName = fullName.ToLower();

fullName = "    bob smith  ";
fullName = fullName.Trim(); //TrimStart() trimEnd

fullName=fullName.PadLeft(10); //.PadRigh(10);

//COmparison
filePath.StartsWith("");
filePath.EndsWith("", StringComparison.OrdinalIgnoreCase );

//Comparison 1 - relational ops (culture aware, case sensitive)
bool areEqual = firstName == lastName;

string input = Console.ReadLine();
//if (input == "A") comapre string and case does matter
    if(input.ToUpper()=="A")
    Console.WriteLine("A");
else if (input == "B")
    Console.WriteLine("B");
else
    Console.WriteLine("other");

//String Compare
if(String.Compare(input, "A", StringComparison.OrdinalIgnoreCase) == 0)
    Console.WriteLine("A");
else if (String.Compare(input, "B", true) == 0) //true ignores case
    Console.WriteLine("B");

//Comparison 3 - String equal

if(String.Equals(input, "A", StringComparison.OrdinalIgnoreCase)) //conmpare strings and case does not matter
    Console.WriteLine("A");