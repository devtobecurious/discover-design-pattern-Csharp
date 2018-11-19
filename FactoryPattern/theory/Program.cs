using System;

namespace theory
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct product = ProductFactory.GetOne();
        }
    }
}
