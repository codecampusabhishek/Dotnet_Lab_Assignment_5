using System;

namespace Dotnet_Lab_Assignment_5
{
class AtmBalanceException: Exception
{
    public AtmBalanceException(string message): base(message)
    {
    }
}
class AtmWithdrawl
{
    static void Main5()
    {
        try
        {
            Console.Write("Enter account balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter withdrawl amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if(amount > balance)
            {
                throw new AtmBalanceException("Insufficient balance! withdrawl can't be processed.");
            }
            if(amount <= 0)
            {
                throw new Exception("Withdrawl amount must be greater than zero");
            }
            balance -= amount;
            Console.WriteLine("Withdrawl successful");
            Console.WriteLine("Remaining Balance: "+balance);
        }
        catch (AtmBalanceException ex)
        {
            Console.WriteLine("Error: "+ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: please enter a valid numeric values");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: "+ ex.Message);
        }
        finally
        {
            Console.WriteLine("Thank you for using the atm");
        }
    }
}
}