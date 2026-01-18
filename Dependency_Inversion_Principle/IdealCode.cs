using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Inversion_Principle_IdealCode;

// MailService no longer depends on concrete implementations
// such as Gmail, Yandex, or Hotmail.
// Instead, it depends on an abstraction (IMailServer),
// which is the core idea of the Dependency Inversion Principle.
class MailService
{
    public void SendMail(IMailServer mailServer, string to, string mail)
    {
        mailServer.SendMail(to, mail);
    }
}

// This interface defines a common contract for all mail services.
// High-level modules (MailService) depend on this abstraction,
// not on low-level concrete implementations.
interface IMailServer
{
    public void SendMail(string to, string mail);
}

// Gmail implements the IMailServer interface.
// MailService does not know about Gmail directly,
// which makes the system more flexible and loosely coupled.
class Gmail : IMailServer
{
    public void SendMail(string to, string mail)
    {
        // sending mail logic...
        Console.WriteLine($"{to} - {mail}");
    }
}


class Yandex : IMailServer
{
    public void SendMail(string to, string mail)
    {
        // sending mail logic...
        Console.WriteLine($"{to} - {mail}");
    }
}

class Hotmail : IMailServer
{
    public void SendMail(string to, string mail)
    {
        // sending mail logic...
        Console.WriteLine($"{to} - {mail}");
    }
}


