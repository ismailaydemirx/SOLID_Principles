#region Not Ideal Code

//using Single_Responsibility_Principle_NotIdealCode;

//Database db = new Database();
//db.Connect();
//db.GetPersons(); // Violates SRP bacause Database class handles both connection and data retrieval
//db.Disconnect();

#endregion

#region Ideal Code

using Single_Responsibility_Principle_IdealCode;

Database db = new Database();
PersonService personService = new PersonService(db);

Person person = new Person()
{
    Id = 1,
    Name = "Ismail Aydemir"
};

db.Connect(); // Database only handles things about database connection so on.

foreach (var p in personService.GetPersons()) //  No SRP violation, each class has a single responsibility
{
    Console.WriteLine($"Id: {p.Id}, Name: {p.Name}");
}

#endregion