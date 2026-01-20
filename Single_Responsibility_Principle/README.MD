# Single Responsibility Principle – Ideal Design Example

This project demonstrates a clean and correct implementation of the
**Single Responsibility Principle (SRP)** using C#.

The goal is to show that SRP applies not only to **classes**, but also to
**methods/functions**, ensuring that each unit of code has a single, well-defined responsibility.

---

## ❌ Problem (Non-Ideal Design)

In the non-ideal design, the `Database` class was responsible for **multiple concerns**:

* Managing database connections
* Retrieving person data

```csharp
Database db = new Database();
db.Connect();
db.GetPersons(); // Violates SRP: Database handles both connection and data retrieval
db.Disconnect();
```

This design violates SRP because the class has **more than one reason to change**
(e.g. connection logic changes vs. data retrieval logic changes).

---

## ✅ Solution (Ideal Design)

The design is improved by **separating responsibilities clearly**.

### Class-Level Responsibilities

* `Database`
  → Handles **only database connection-related operations**

* `PersonService`
  → Handles **business logic and data retrieval**

* `Person`
  → Represents the **data model**

Each class now has **one responsibility and one reason to change**.

---

## 🧩 Design Overview

```csharp
Database db = new Database();
PersonService personService = new PersonService(db);

Person person = new Person()
{
    Id = 1,
    Name = "Ismail Aydemir"
};

db.Connect(); // Database is responsible only for connection logic

foreach (var p in personService.GetPersons())
{
    Console.WriteLine($"Id: {p.Id}, Name: {p.Name}");
}
```

---

## 🧠 Method-Level SRP (Important Detail)

SRP does not stop at the class level.

👉 **Each method/function should also do only one job.**

### ❌ Method SRP Violation Example

```csharp
public void SavePerson(Person person)
{
    Validate(person);
    OpenConnection();
    InsertIntoDatabase(person);
    LogOperation();
}
```

This method performs **multiple responsibilities**, making it harder to test and maintain.

---

### ✅ Single Job per Method (Preferred)

```csharp
public void SavePerson(Person person)
{
    ValidatePerson(person);
    SaveToDatabase(person);
}

private void ValidatePerson(Person person)
{
    // validation logic
}

private void SaveToDatabase(Person person)
{
    // persistence logic
}
```

Now:

* Each method has a **single purpose**
* Code is easier to read, test, and refactor

---

## 🔑 Key Principles Applied

* One responsibility per class
* One job per method
* Clear separation of concerns
* Low coupling, high cohesion

---

## 📌 Summary

The **Single Responsibility Principle** should be applied at **all levels**:

* ✔ Class level → one responsibility
* ✔ Method level → one job

Following this approach results in **cleaner, more maintainable, and scalable code**,
fully aligned with **SOLID** and **Clean Code** principles.

---