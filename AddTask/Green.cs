using System;

namespace AddTask
{
    class Green : Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
        }
    }
}
