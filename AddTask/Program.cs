using System;

namespace AddTask
{
    class Program
    {
        static void Main()
        {
            Cyan set_color = new Cyan();

            Printer printer = set_color;

            Cyan color = (Cyan)printer;

            color.Print("It's not a piece of cake.");

            Console.ReadLine();
        }
    }
}
