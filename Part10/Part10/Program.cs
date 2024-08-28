//10. Temperature Converter:

Console.WriteLine("Do you want to convert from Fahrenheit to Celsius (F to C) or from Celsius to Fahrenheit (C to F)?");
string conversionType = Console.ReadLine();

Console.WriteLine("Enter the temperature: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int temperature))
{
    if (conversionType.ToLower() == "f to c")
    {
        double celsius = (temperature - 32) * 5 / 9;
        Console.WriteLine("The converted temperature is: " + celsius + " Celsius");
    }
    else if (conversionType.ToLower() == "c to f")
    {
        double fahrenheit = temperature * 9 / 5 + 32;
        Console.WriteLine("The converted temperature is: " + fahrenheit + " Fahrenheit");
    }
    else
    {
        Console.WriteLine("Invalid conversion type. Please enter 'F to C' or 'C to F'.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}