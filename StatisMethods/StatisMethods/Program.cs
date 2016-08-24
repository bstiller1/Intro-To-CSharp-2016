using System;
using System.Windows.Forms;

namespace StaticMethods
{
    class Program
    {
        private const string CAPTION = "System.Array.Methods Illustrated";
        static void Main(string[] args)
        {
            double[] waterDepth = { 45, 19, 2, 16.8, 190, 0.8, 510, 6, 18 };
            double[] w = new double[20];

            DisplayOutput(waterDepth, "WaterDepth Array\n\n");

            Array.Copy(waterDepth, 2, w, 0, 5);
            Array.Sort(w);
            DisplayOutput(w, "Array w Sorted\n\n");

            Array.Reverse(w);
            DisplayOutput(w, "Array w reversed\n\n");
        }

        public static void DisplayOutput(double[] anArray, string msg)
        {
            foreach(double wVal in anArray)
            {
                if(wVal > 0)
                {
                    msg += wVal + "\n";
                }
            }
            MessageBox.Show(msg, CAPTION);
        }    
    } 
} 
