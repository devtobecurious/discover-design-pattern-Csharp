using System;

namespace theory
{
    class Program
    {
        static void Main(string[] args)
        {
            Component<string> item = new Component<string>("test 0001");
            Component<string> item2 = new Component<string>("test 0002");
            Composite<string> container = new Composite<string>("composite 001");

            container.Add(item);
            container.Add(item2);

            container.Display();
        }
    }
}
