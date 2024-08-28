//1. Even or Odd:

Console.WriteLine("Enter a number: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    if (number % 2 == 0)
    {
        Console.WriteLine("The number is even");
    }
    else
    {
        Console.WriteLine("The number is odd");
    }

}
else
{
    Console.WriteLine("Invalid input");
}
