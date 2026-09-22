using System;
using System.IO;

namespace Dotnet_Lab_Assignment_5
{
    class Que_9_StudentFile
    {
        static void Main()
        {
            string filePath = "student.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Name: Abhishek");
                    writer.WriteLine("Roll No: 101");
                    writer.WriteLine("Course: MCA");
                    writer.WriteLine("University: GLA University");
                }

                Console.WriteLine("Student details written successfully.");
                Console.WriteLine("\nStudent Details:");

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string? line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}