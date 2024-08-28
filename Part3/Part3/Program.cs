//5. Maximum of Three:

Console.WriteLine("Enter three numbers: ");
string input1 = Console.ReadLine();
string input2 = Console.ReadLine();
string input3 = Console.ReadLine();

if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2) && int.TryParse(input3, out int num3))
{
    int max = Math.Max(num1, Math.Max(num2, num3));
    Console.WriteLine("The maximum number is: " + max);
}
else
{
    Console.WriteLine("Invalid input. Please enter valid numbers.");
}