using System;


namespace Dotnet_Lab_Assignment_5
{
class Que_3_ArrayIndexExample
{
    static void Main3()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        try
        {
            Console.Write("Enter an index (0-4): ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value = " + numbers[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: Index must be between 0 and 4.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid integer.");
        }
    }
}
}