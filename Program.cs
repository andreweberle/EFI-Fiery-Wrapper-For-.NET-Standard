using System;
using EFI;

namespace myApplicationName
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assign AccessKey From EFI
            Fiery.AccessKey = "xxx";

            // Create New Printer.
            Fiery.Printer printer = new Fiery.Printer();
        }
    }
}
