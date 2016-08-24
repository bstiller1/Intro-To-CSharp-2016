using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] color = { "red", "green", "blue" };
            for(int i = 0; i < color.Length; i++)
            {
                Console.WriteLine(i + 1 + ": " + color[i]);
            }
            Console.ReadKey();

        }
    }
}
