using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility_Principle_IdealCode;

// Database class has the single responsibility of managing database connections and queries
// It does not handle any data retrieval logic
// It does not contiain methods which are not about database connection and query execution
class Database
{
    public void Connect()
    {
        // Code to connect to the database
    }
    public void Disconnect()
    {
        // Code to disconnect from the database
    }
    public void ExecuteQuery(string query)
    {
        // Code to execute a database query
    }
}

// PersonRepository class has the single responsibility of handling person data
// It uses the Database class to perform data access operations
// It does not violate the Single Responsibility Principle because it focuses solely on person data retrieval
class PersonService
{
    private readonly Database _database;
    public PersonService(Database database)
    {
        _database = database;
    }
    public List<Person> GetPersons()
    {
        _database.Connect();
        // Code to get persons from the database
        _database.Disconnect();
        return new()
        {
            new() { Id = 1, Name = "John Doe"},
            new() { Id = 2, Name = "Jane Smith"},
            new() { Id = 3, Name = "Alice Johnson"}
        };
    }
}