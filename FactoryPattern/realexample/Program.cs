using System;

namespace realexample
{
    class Program
    {
        static void Main(string[] args)
        {
            IGun gun = null;

            gun = GunFactory.CreateOne(1);
            gun.Shoot();

            gun = GunFactory.CreateOne(2);
            gun.Shoot();
        }
    }
}
