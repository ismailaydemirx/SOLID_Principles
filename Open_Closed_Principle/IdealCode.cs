using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Closed_Principle_IdealCode;

// In this example, the MoneySender class is closed for modification.
// If we want to add support for a new bank, we can do so by creating a new class
// that implements the IBank interface, without modifying the MoneySender class.
class MoneySender
{
    // The SendMoney method now takes an IBank interface as a parameter,
    // allowing it to work with any bank that implements the interface.
    // So, we can add new banks without changing this method.
    // We also used loose coupling by depending on an abstraction (IBank) rather than concrete implementations.
    public void SendMoney(IBank bank, int amount, string accountNumber)
    {
        bank.SendMoney(amount, accountNumber);
    }
}

interface IBank
{
    void SendMoney(int amount, string accountNumber);
}

class Bawag : IBank
{
    public void SendMoney(int amount, string accountNumber)
    {
        // Logic to send money via Bawag
        Console.WriteLine($"Sending {amount} via Bawag from account {accountNumber}");
    }
}

class Santander : IBank
{
    public void SendMoney(int amount, string accountNumber)
    {
        // Logic to send money via Santander
        Console.WriteLine($"Sending {amount} via Santander from account {accountNumber}");
    }
}

class BankOfAmerica : IBank
{
    public void SendMoney(int amount, string accountNumber)
    {
        // Logic to send money via Bank of America
        Console.WriteLine($"Sending {amount} via Bank of America from account {accountNumber}");
    }
}