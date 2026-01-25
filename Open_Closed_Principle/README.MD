# Open/Closed Principle – Ideal Design Example

This project demonstrates a clean and correct implementation of the
**Open/Closed Principle (OCP)** using C#.

The goal is to show how a system can be **open for extension but closed for modification**, allowing new behavior to be added without changing existing, tested code.

---

## ❌ Problem (Non-Ideal Design)

In a non-ideal design, the `MoneySender` class would contain logic for each bank:

* `if / else` or `switch` statements for different banks
* Code modification required every time a new bank is added

```csharp
public void SendMoney(string bankName, int amount, string accountNumber)
{
    if (bankName == "Bawag")
    {
        // send via Bawag
    }
    else if (bankName == "Santander")
    {
        // send via Santander
    }
}
```

This design violates OCP because:

* Adding a new bank requires **modifying existing code**
* The class has **multiple reasons to change**
* Risk of breaking existing functionality increases over time

---

## ✅ Solution (Ideal Design)

The design is improved by **introducing an abstraction**.

### Core Idea

* `MoneySender` depends on an **interface**, not concrete bank implementations
* Each bank implements the same contract (`IBank`)
* New banks can be added **without changing MoneySender**

---

## 🧩 Design Overview

```csharp
MoneySender moneySender = new MoneySender();

// Send money via Bawag
moneySender.SendMoney(new Bawag(), 100, "123456");

// Send money via Santander with no changes to MoneySender
moneySender.SendMoney(new Santander(), 200, "654321");

// Send money via Bank of America with no changes to MoneySender
moneySender.SendMoney(new BankOfAmerica(), 300, "112233");
```

---

## 🧠 Key Classes and Responsibilities

### `MoneySender`

```csharp
class MoneySender
{
    public void SendMoney(IBank bank, int amount, string accountNumber)
    {
        bank.SendMoney(amount, accountNumber);
    }
}
```

* **Closed for modification**
* Works with any bank implementing `IBank`
* Depends on an abstraction (loose coupling)

---

### `IBank`

```csharp
interface IBank
{
    void SendMoney(int amount, string accountNumber);
}
```

* Defines a common contract
* Enables polymorphic behavior

---

### Bank Implementations

```csharp
class Bawag : IBank
{
    public void SendMoney(int amount, string accountNumber)
    {
        Console.WriteLine($"Sending {amount} via Bawag from account {accountNumber}");
    }
}

class Santander : IBank
{
    public void SendMoney(int amount, string accountNumber)
    {
        Console.WriteLine($"Sending {amount} via Santander from account {accountNumber}");
    }
}

class BankOfAmerica : IBank
{
    public void SendMoney(int amount, string accountNumber)
    {
        Console.WriteLine($"Sending {amount} via Bank of America from account {accountNumber}");
    }
}
```

* **Open for extension**
* New banks can be added as new classes
* No existing code is modified

---

## 🔑 Key Principles Applied

* Open for extension, closed for modification
* Programming to an interface
* Loose coupling
* Polymorphism instead of conditionals

---

## 📌 Summary

The **Open/Closed Principle** ensures that:

* Existing code remains stable and safe
* New functionality is added via extensions
* The system scales without growing complexity

By depending on abstractions instead of concrete implementations,
this design fully aligns with **SOLID** and **Clean Code** principles.

---