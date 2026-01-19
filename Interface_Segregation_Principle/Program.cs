#region Not Ideal Code

//using Interface_Segregation_Principle_NotIdealCode;

//// Create a printer directly
//HPPrinter hpPrinter = new HPPrinter();

//// HPPrinter supports all operations
//hpPrinter.Print();
//hpPrinter.PrintDuplex();
//hpPrinter.Scan();
//hpPrinter.Fax();

//// Create another printer
//SamsungPrinter samsungPrinter = new SamsungPrinter();

//// These methods exist only because SamsungPrinter
//// was forced to implement the interface

//samsungPrinter.Print();
//samsungPrinter.PrintDuplex();

//samsungPrinter.Fax();   // Throws NotImplementedException
//samsungPrinter.Scan();  // Throws NotImplementedException

//// This is the real problem:
//// The class exposes methods that do not actually work.
//// Even though the object is concrete,
//// the developer still cannot trust the API.
//// A class should not contain unusable methods.
//// This violates Interface Segregation Principle.

#endregion


#region Ideal Code

using Interface_Segregation_Principle_IdealCode;

// Create printer directly
SamsungPrinter samsungPrinter = new SamsungPrinter();

// Only valid operations are available
samsungPrinter.Print();
samsungPrinter.PrintDuplex();

// Scan and Fax are NOT visible here
// Because SamsungPrinter does not support them

// Create a printer that supports scanning and fax
HPPrinter hpPrinter = new HPPrinter();

hpPrinter.Print();
hpPrinter.PrintDuplex();
hpPrinter.Scan();
hpPrinter.Fax();

// Each class exposes only what it can actually do
// No runtime exceptions
// IntelliSense is reliable
// Clear and safe API design

#endregion
