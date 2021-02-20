using System;

namespace AddTask
{
    class Red : Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
        }
    }
}
