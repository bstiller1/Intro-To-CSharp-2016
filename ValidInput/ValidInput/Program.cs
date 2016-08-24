using static System.Console;

namespace ValidInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int intVal;
            string inStrVal;

            WriteLine("Enter an Integer: ");
            inStrVal = ReadLine();
            while(int.TryParse(inStrVal, out intVal) == false)
            {
                WriteLine("Invalid input");
                WriteLine("Please re-enter an integer value.");
                inStrVal = ReadLine();
            }
            WriteLine("Valid value entered: " + intVal);
            ReadKey();
        }

    }
}
