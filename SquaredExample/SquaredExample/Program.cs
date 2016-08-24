using System;
using static System.Console;
namespace Square
{
    public class SquareExample
    {
        public static void Main()
        {
            DisplayMessage();

    }
        public void DisplayMessage()
        {
            Write("This is ");
            Write("an example of a method");
            WriteLine("body.");
            return;     // no value is returned
        }
    }
}
