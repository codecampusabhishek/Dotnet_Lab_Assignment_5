using System;


namespace Dotnet_Lab_Assignment_5
{
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message)
        : base(message)
    {
    }
}

class Que_8_BankAccount
{
    private double balance;

    public Que_8_BankAccount(double balance)
    {
        this.balance = balance;
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            throw new InsufficientBalanceException(
                "Withdrawal amount exceeds available balance.");
        }

        balance = balance - amount;

        Console.WriteLine("Withdrawal successful.");
        Console.WriteLine("Remaining balance: " + balance);
    }
}

class BankSystem
{
    static void Main8()
    {
        Que_8_BankAccount account = new Que_8_BankAccount(10000);

        try 
        {
            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            account.Withdraw(amount);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Enter a valid amount.");
        }
        finally
        {
            Console.WriteLine("Transaction completed.");
        }
    }
}
}