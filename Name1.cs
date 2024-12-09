using System;

class Program
{
    static void Main(string[] args)
    {
        // Taking input from the user
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        // Displaying the formatted output
        Console.WriteLine($"My name is: {firstName} {lastName}");
        Console.WriteLine($"My age is: {age}");
    }
}
