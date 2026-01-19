using System;

namespace Interface_Segregation_Principle_IdealCode
{
    // Only basic print operations
    interface IPrinter
    {
        void Print();
        void PrintDuplex();
    }

    // For devices that support scanning
    interface IScannable
    {
        void Scan();
    }

    // For devices that support faxing
    interface IFaxable
    {
        void Fax();
    }

    // HP printer supports print, scan and fax
    class HPPrinter : IPrinter, IScannable, IFaxable
    {
        public void Print()
        {
            // Print document
        }

        public void PrintDuplex()
        {
            // Print document on both sides
        }

        public void Scan()
        {
            // Scan document
        }

        public void Fax()
        {
            // Send fax
        }
    }

    // Samsung printer supports print and duplex print only
    class SamsungPrinter : IPrinter
    {
        public void Print()
        {
            // Print document
        }

        public void PrintDuplex()
        {
            // Print document on both sides
        }
    }

    // Lexmark printer supports print and fax
    class LexmarkPrinter : IPrinter, IFaxable
    {
        public void Print()
        {
            // Print document
        }

        public void PrintDuplex()
        {
            // Print document on both sides
        }

        public void Fax()
        {
            // Send fax
        }
    }
}
