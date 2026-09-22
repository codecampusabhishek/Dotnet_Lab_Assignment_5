using System;


namespace Dotnet_Lab_Assignment_5
{
class Que_6_StudentMarks
{
    static void Main6()
    {
        int[] marks = new int[5];

        try
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter marks for subject " + (i + 1) + ": ");

                int mark = Convert.ToInt32(Console.ReadLine());

                if (mark < 0 || mark > 100)
                {
                    throw new ArgumentOutOfRangeException(
                        "Marks must be between 0 and 100.");
                }

                marks[i] = mark;
            }

            Console.WriteLine("\nMarks entered successfully.");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(
                    "Subject " + (i + 1) + ": " + marks[i]);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter numeric marks only.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Marks entry process completed.");
        }
    }
}
}