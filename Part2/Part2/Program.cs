//2. Age Bracket:

Console.WriteLine("Enter your age: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int age))
{
    if (age < 13)
    {
        Console.WriteLine("You are a child");
    }
    else if (age >= 13 && age < 19)
    {
        Console.WriteLine("You are a teenager");
    }
    else if (age > 19)
    {
        Console.WriteLine("You are an adult");
    }
}
