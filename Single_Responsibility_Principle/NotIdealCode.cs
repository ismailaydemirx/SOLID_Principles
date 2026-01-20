using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility_Principle_NotIdealCode;

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

    // This method violates the Single Responsibility Principle
    // because it mixes data access with data retrieval logic
    public void GetPersons()
    {
        // Code to get persons from the database
    }
}