using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Inversion_Principle_NotIdealCode;

// In this mail service we depend on Gmail so this is a dependency
// When we want to use another mail service we will need to create another function
// This is a bad code
// Here it says: Dependency Inversion, so we need to invert the dependencions in IdealCode.cs
class MailService
{
    public void SendMail(Gmail gmail)
    {
        gmail.Send("..");
    }
}

class Gmail
{
    public void Send(string mail)
    {
        // sending mail logic...
        Console.WriteLine(mail);
    }
}


class Yandex
{
    public void Send(string mail)
    {
        // sending mail logic...
        Console.WriteLine(mail);
    }
}

class Hotmail
{
    public void Send(string mail)
    {
        // sending mail logic...
        Console.WriteLine(mail);
    }
}


