//7. Discount System:

Console.WriteLine("Enter a price: ");
string input = Console.ReadLine();


if (int.TryParse(input, out int price))
{
    if (price >= 1000)
    {
        Console.WriteLine("The price is " + (price - (price * 0.1)));
    }
    else
    {
        Console.WriteLine("The price is " + price);
    }


}