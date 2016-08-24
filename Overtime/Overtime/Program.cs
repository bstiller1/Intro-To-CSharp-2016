using static System.Console;

namespace Overtime
{
    class Program
    {
        static void Main(string[] args)
        {
        decimal hoursWorked = 45;
        decimal payRate = 35;
        decimal payAmount;

            if (hoursWorked > 40)
            {
                payAmount = (hoursWorked - 40) * payRate * 1.5M  + payRate * 40;
                WriteLine("You worked {0} hours overtime. Net Pay: {1:C}", hoursWorked - 40, payAmount);

            }
            else
                payAmount = hoursWorked * payRate;

            WriteLine("Displayed, whether the expression evaluates" +
                              " true or false");
           ReadLine(); // Keep on Screen

        }
    }
}
