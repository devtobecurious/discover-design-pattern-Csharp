using System;

namespace theory
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = null;

            abstraction = new Abstraction(new ImplementationA());
            System.Console.WriteLine(abstraction.Operation());

            abstraction = new Abstraction(new ImplementationB());
            System.Console.WriteLine(abstraction.Operation());
        }
    }
}
