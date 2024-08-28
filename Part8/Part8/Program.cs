//8. Weekdays:

Console.WriteLine("Enter a number between 1 and 7: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int day))
{
    if (day >= 1 && day <= 7)
    {
        string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.WriteLine("It's " + daysOfWeek[day - 1]);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
    }

}