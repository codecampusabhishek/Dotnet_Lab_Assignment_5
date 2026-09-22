using System;

namespace Dotnet_Lab_Assignment_5
{
class InvalidLoginException : Exception
{
    public InvalidLoginException(string message) : base(message)
    {
    }
}
class Que_7_LoginSystem
{
    static void Main7()
    {
        const string correctUsername = "admin";
        const string correctPassword = "12345";

        try
        {
            Console.Write("Enter username: ");
            string? username = Console.ReadLine();

            Console.Write("Enter password: ");
            string? password = Console.ReadLine();

            if (username != correctUsername ||
                password != correctPassword)
            {
                throw new InvalidLoginException(
                    "Invalid username or password.");
            }

            Console.WriteLine("Login successful!");
        }
        catch (InvalidLoginException ex)
        {
            Console.WriteLine("Login failed: " + ex.Message);
        }
    }
}
}