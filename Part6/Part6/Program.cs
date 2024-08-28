//6. Positive, Negative, or Zero:

Console.WriteLine("Enter a number: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    if (number > 0)
    {
        Console.WriteLine("The number is positive");
    }
    else if (number < 0)
    {
        Console.WriteLine("The number is negative");
    }
    else
    {
        Console.WriteLine("The number is zero");
    }
}