using System;

public class BankAccount
{
    private decimal balance;

    public decimal Balance
    {
        get
        {
            return balance;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Balance cannot be negative");
            }
            balance = value;
        }
    }

    public BankAccount(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Deposit amount cannot be negative");
        }
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Withdrawal amount cannot be negative");
        }

        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient balance");
        }

        Balance -= amount;
    }
}