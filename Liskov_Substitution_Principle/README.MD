# Liskov Substitution Principle – Ideal Design Example

This project demonstrates a correct and clean implementation of the  
**Liskov Substitution Principle (LSP)** using C#.

The goal is to show how to avoid forcing derived classes to implement
behaviors they do not support.

---

## ❌ Problem (Non-Ideal Design)

In the initial design, the `Cloud` base class defined a `Translate()` method.

Some cloud providers (like `Azure`) do not support translation.
This caused runtime exceptions when `Translate()` was called.

This situation violates the Liskov Substitution Principle.

---

## ✅ Solution (Ideal Design)

The design was improved by separating responsibilities.

- `Cloud` defines only common behavior.
- Optional behavior is moved to a separate interface.

### Key Changes

- `Translate()` is removed from the `Cloud` base class
- A new interface `ITranslatable` is introduced
- Only cloud providers that support translation implement `ITranslatable`

---

## 🧩 Design Overview

```csharp
abstract class Cloud
{
    public abstract void MachineLearning();
}

interface ITranslatable
{
    void Translate();
}
