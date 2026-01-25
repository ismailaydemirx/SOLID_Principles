using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Closed_Principle_NotIdealCode;

// In this example, the MoneySender class is not closed for modification.
// If we want to add support for a new bank, we have to modify the MoneySender class,
// which violates the Open/Closed Principle.
// These classes also not doing a good job encapsulating the bank-specific logic.
class MoneySender
{
    public void SendMoney(int amount)
    {
        Bawag bawag = new Bawag();
        bawag.SendingAccount("123456");
        bawag.SendMoney(amount);

    }
}

class Bawag
{
     string AccountNumber { get; set; }

    public void SendingAccount(string accountNumber)
    {
        AccountNumber = accountNumber;
    }
    public void SendMoney(int amount)
    {
        // Logic to send money via Bawag
        Console.WriteLine($"Sending {amount} via Bawag from account {AccountNumber}");
    }
}

class Santander
{
    public string AccountNumber { get; set; }
    public void SendMoney(int amount)
    {
        // Logic to send money via Santander
        Console.WriteLine($"Sending {amount} via Santander from account {AccountNumber}");
    }
}

class BankOfAmerica
{
    public string AccountNumber { get; set; }
    public void SendMoney(int amount)
    {
        // Logic to send money via Bank of America
        Console.WriteLine($"Sending {amount} via Bank of America from account {AccountNumber}");
    }
}
