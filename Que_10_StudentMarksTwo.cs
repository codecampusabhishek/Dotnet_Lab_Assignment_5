using System;
using System.IO;
namespace Dotnet_Lab_Assignment_5
{
class Que_10_StudentMarksTwo
{
    static void Main10()
    {
        try
        {
            StreamReader reader = new StreamReader("Marks.txt");
                int total = 0;
                int count = 0;
                int highest = int.MinValue;
                int lowest = int.MaxValue;

                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    int marks = Convert.ToInt32(line);

                    total += marks;
                    count++;

                    if (marks > highest)
                    {
                        highest = marks;
                    }

                    if (marks < lowest)
                    {
                        lowest = marks;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine("The file contains no marks.");
                    return;
                }

                double average = (double)total / count;

                Console.WriteLine("Total = " + total);
                Console.WriteLine("Average = " + average);
                Console.WriteLine("Highest = " + highest);
                Console.WriteLine("Lowest = " + lowest);
            }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File was not found.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: File contains invalid marks.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
}