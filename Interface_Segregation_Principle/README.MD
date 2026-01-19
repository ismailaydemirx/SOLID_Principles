# Interface Segregation Principle – Ideal Design Example

This project demonstrates a clean and correct implementation of the  
**Interface Segregation Principle (ISP)** using C#.

The goal is to show why interfaces should be small, focused,
and designed around real capabilities.

---

## ❌ Problem (Non-Ideal Design)

In the initial design, a single `IPrinter` interface defined multiple behaviors:

- Print()
- Duplex Print()
- Scan()
- Fax()

All printer classes were forced to implement every method.

Some printers (like `SamsungPrinter`) do not support scanning or faxing.
Because of this, these methods were implemented by throwing runtime exceptions.

This leads to:

- Unusable methods in the class
- Runtime errors
- Confusing and unsafe APIs

This design violates the Interface Segregation Principle.

---

## ✅ Solution (Ideal Design)

The design was improved by splitting the interface into smaller,
responsibility-focused interfaces.

Each printer class now implements **only the behaviors it actually supports**.

### Key Changes

- `IPrinter` contains only basic print operations
- Scanning and faxing are moved to separate interfaces
- Classes are no longer forced to implement unused methods
- Runtime exceptions are eliminated

---

## 🧩 Design Overview

```csharp
interface IPrinter
{
    void Print();
    void PrintDuplex();
}

interface IScannable
{
    void Scan();
}

interface IFaxable
{
    void Fax();
}
````

---

## 🖨 Example Implementations

```csharp
class SamsungPrinter : IPrinter
{
    public void Print() { }
    public void PrintDuplex() { }
}
```

```csharp
class HPPrinter : IPrinter, IScannable, IFaxable
{
    public void Print() { }
    public void PrintDuplex() { }
    public void Scan() { }
    public void Fax() { }
}
```

---

## Interface Segregation Principle 🆚 Liskov Substitution Principle

| Interface Segregation Principle (ISP)               | Liskov Substitution Principle (LSP)               |
| --------------------------------------------------- | ------------------------------------------------- |
| Focuses on **interface design**                     | Focuses on **inheritance and behavior**           |
| Prevents **fat interfaces**                         | Prevents **behavioral breaking**                  |
| Classes should not implement methods they don’t use | Subclasses must fully respect base class behavior |
| Problem appears at **design / compile time**        | Problem usually appears at **runtime**            |
| Solved by **splitting interfaces**                  | Solved by **correct abstraction or separation**   |
| Concerned with **what a class exposes**             | Concerned with **how a class behaves**            |

---

### One-Line Summary

> **ISP** ensures classes depend only on what they actually need.
> **LSP** ensures subclasses can safely replace their base classes.

---

## 🎯 Summary

* Each class exposes only valid operations
* IntelliSense shows only usable methods
* No runtime exceptions
* Clear and maintainable design

This is a practical and real-world example of the
**Interface Segregation Principle** in action.

---