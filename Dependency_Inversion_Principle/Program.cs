#region Not Ideal Code

// In the not-ideal implementation, MailService depends directly
// on a concrete class (Gmail).
// This makes the code tightly coupled and hard to extend.

// using Dependency_Inversion_Principle_NotIdealCode;

// MailService mailService = new();
// mailService.SendMail(new Gmail());

#endregion

#region Ideal Code

using Dependency_Inversion_Principle_IdealCode;

// In the ideal implementation, MailService depends on an abstraction
// (IMailServer) instead of a concrete mail provider.
// This allows us to easily switch between different mail services.

MailService mailService = new();
mailService.SendMail(new Yandex(), "Ismail", "Don't forget about Dependency Inversion");

// We can change the mail server without modifying MailService.
// This demonstrates the Dependency Inversion Principle in action.
mailService.SendMail(new Gmail(), "Aydemir", "Now you are learning this topic");

#endregion
