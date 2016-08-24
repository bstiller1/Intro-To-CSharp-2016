﻿using static System.Console;

namespace StatePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string stateAbbrev;

            WriteLine("Enter the state abbreviation. ");
            WriteLine("Its full name will be displayed");
            WriteLine();
            stateAbbrev = ReadLine();

            switch(stateAbbrev)
            {
                case "AL":
                case "al":
                    WriteLine("Alabama");
                    break;
                case "FL":
                case "fl":
                    WriteLine("Florida");
                    break;
                case "GA":
                    WriteLine("Georgia");
                    break;
                case "IL":
                    WriteLine("Illinois");
                    break;
                case "KY":
                    WriteLine("Kentucky");
                    break;
                case "MI":
                    WriteLine("Michigan");
                    break;
                case "OK":
                    WriteLine("Oklahoma");
                    break;
                case "TX":
                    WriteLine("Texas");
                    break;

                default: WriteLine("No Match");
                    break;
            }
            ReadKey();
        }
    }
}