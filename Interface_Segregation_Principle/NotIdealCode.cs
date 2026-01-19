using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Segregation_Principle_NotIdealCode;

interface IPrinter
{
    void Print();
    void Fax();
    void Scan();
    void PrintDuplex();
}

class HPPrinter : IPrinter
{
    public void Fax()
    {
        // Fax logic.
    }

    public void Print()
    {
        // Print logic.
    }

    public void PrintDuplex()
    {
        // Print Duplex logic.
    }

    public void Scan()
    {
        // Scan logic.
    }
}

class SamsungPrinter : IPrinter
{
    public void Fax()
    {
        throw new NotImplementedException();
    }

    public void Print()
    {
        // Print logic.
    }

    public void PrintDuplex()
    {
        // Print Duplex logic.
    }

    public void Scan()
    {
        throw new NotImplementedException();
    }
}

class LexmarkPrinter : IPrinter
{
    public void Fax()
    {
        // Fax logic.
    }

    public void Print()
    {
        // Print logic.
    }

    public void PrintDuplex()
    {
        // Print Duplex logic.
    }

    public void Scan()
    {
        throw new NotImplementedException();
    }
}