using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int outer = 0; outer < 3; outer++)
                for (int inner = 1; inner < 2; inner++)
                    Console.WriteLine(outer.ToString(), inner);

            Console.ReadKey();
}
    }
}
