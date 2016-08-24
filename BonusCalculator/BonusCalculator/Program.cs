using static System.Console;

namespace BonusCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inValue;
            decimal salesForYear;
            decimal bonusAmount = 0M;

            WriteLine("Do you get a bonus this year?");
            WriteLine();
            WriteLine("To determine if you are due one,");
            WriteLine("enter your gross sales figure: ");
            inValue = ReadLine();
            salesForYear = System.Convert.ToDecimal(inValue);
            if(salesForYear > 500000.00M)
            {
                WriteLine();
                WriteLine("Yes, you get a bonus!");
                bonusAmount = 1000.00M;
            }
            WriteLine("Bonus for the year: " + bonusAmount);
            ReadLine();

        }
    }
}
