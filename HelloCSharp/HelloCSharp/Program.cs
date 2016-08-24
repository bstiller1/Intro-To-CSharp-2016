using System;

namespace HelloCSharp
{
    class Program 
    {
        public string newVar = "This is a global variable";
        static void Main(string[] args)
        {
            string newVar1 = "This is a local variable";
            NewClass new1 = new NewClass();
            Console.WriteLine(new1.Hello(newVar1));
            Console.WriteLine(new1.ToString("Hi!"));
            //new1.Hello("Hello CSharp!");
            return;
            
        }
    }
}
