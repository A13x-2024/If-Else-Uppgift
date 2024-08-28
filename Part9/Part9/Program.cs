//9. Password Checker:


Console.WriteLine("Enter your password: ");
string input = Console.ReadLine();

string predefinedPassword = "CSharp123";

if (input == predefinedPassword)
{
    Console.WriteLine("Access granted");
}
else
{
    Console.WriteLine("Access denied");
}