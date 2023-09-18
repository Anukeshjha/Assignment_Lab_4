using System;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(1000);

        Console.WriteLine("Current balance: " + account.Balance);

        account.Deposit(500);
        Console.WriteLine("Balance after deposit: " + account.Balance);

        try
        {
            account.Withdraw(1500);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        account.Withdraw(300);
        Console.WriteLine("Balance after withdrawal: " + account.Balance);
        Console.ReadLine();
    }
}
