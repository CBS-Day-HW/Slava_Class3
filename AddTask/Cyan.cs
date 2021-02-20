using System;

namespace AddTask
{
    class Cyan : Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(value);
        }
    }
}
