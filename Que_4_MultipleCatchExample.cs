using System;


namespace Dotnet_Lab_Assignment_5
{
class Que_5_ATM
{
    static void Main4()
    {
        try
        {
            Console.Write("Enter account balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > balance)
            {
                throw new Exception("Insufficient balance.");
            }

            balance = balance - amount;

            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Remaining balance = " + balance);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid amount.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Thank you for using the ATM.");
        }
    }
}
}