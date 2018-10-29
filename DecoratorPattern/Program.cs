using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun defaultGun = new Gun();
            Wookie chewie = new Wookie(defaultGun);

            chewie.Shoot();
        }
    }
}
