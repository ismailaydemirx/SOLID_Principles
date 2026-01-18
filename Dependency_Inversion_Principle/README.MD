# Dependency Inversion Principle – Ideal Design Example

This project demonstrates a clean and correct implementation of the
**Dependency Inversion Principle (DIP)** using C#.

The goal is to show how high-level modules should not depend on low-level
modules, but instead depend on abstractions.

---

## ❌ Problem (Non-Ideal Design)

In the initial design, the `MailService` class depends directly on a concrete
mail provider (`Gmail`).

This creates several problems:

* `MailService` is tightly coupled to `Gmail`
* Adding a new mail provider requires modifying `MailService`
* The code is hard to extend and maintain

This design violates the Dependency Inversion Principle.

---

## ✅ Solution (Ideal Design)

The design is improved by introducing an abstraction (`IMailServer`).

* `MailService` depends on the `IMailServer` interface
* Concrete mail providers implement this interface
* Dependencies are inverted

As a result, `MailService` no longer cares which mail provider is used.

---

## 🧩 Design Overview

```csharp
class MailService
{
    public void SendMail(IMailServer mailServer, string to, string mail)
    {
        mailServer.SendMail(mail);
    }
}

interface IMailServer
{
    void SendMail(string to, string mail);
}
```

---

## 🧱 Concrete Implementations

```csharp
class Gmail : IMailServer
{
    public void SendMail(string to, string mail)
    {
        Console.WriteLine($"{to} - {mail}");
    }
}

class Yandex : IMailServer
{
    public void SendMail(string to, string mail)
    {
        Console.WriteLine($"{to} - {mail}");
    }
}

class Hotmail : IMailServer
{
    public void SendMail(string to, string mail)
    {
        Console.WriteLine($"{to} - {mail}");
    }
}
```

---

## 🚀 Benefits of This Design

* High-level modules depend on abstractions
* Low-level modules can be changed or extended easily
* No modification is required when adding new mail providers
* The code follows both **Dependency Inversion** and **Open/Closed** principles

---

## 📌 Summary

The Dependency Inversion Principle helps create:

* Loosely coupled systems
* More flexible and testable code
* Cleaner and more maintainable designs

This example demonstrates how a small abstraction can significantly
improve the overall architecture.

---