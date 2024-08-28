//3. Ask the user to input their test score (0-100):

Console.WriteLine("Enter your test score: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int score))
{
    if (score < 60)
    {
        Console.WriteLine("F");
    }
    if (score >= 60 && score < 70)
    {
        Console.WriteLine("D");
    }
    if (score >= 70 && score < 80)
    {
        Console.WriteLine("C");
    }
    if (score >= 80 && score < 90)
    {
        Console.WriteLine("B");
    }
    if (score >= 90 && score <= 100)
    {
        Console.WriteLine("A");
    }
}