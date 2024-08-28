//4. Leap Year Checker:


Console.WriteLine("Enter a year: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int year))
{
    if (year % 4 == 0)
    {
        Console.WriteLine("The year is a leap year");
    }
    else
    {
        Console.WriteLine("The year is not a leap year");
    }
}
