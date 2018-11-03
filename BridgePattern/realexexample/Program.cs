using System;

namespace realexexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IWithLaser laser = new OldLaser();
            Gun gun = new Gun(laser);
            Ship shipForChewie = new Ship(gun);

            Gun newGun = new Gun(laser);
            Ship badShip = new Ship(newGun);
            shipForChewie.Attack(badShip);

            // Here, Chewie try to use the new version of the laser
            gun = new Gun(new Version2Laser());
            shipForChewie.CurrentGun = gun;
            shipForChewie.Attack(badShip);
        }
    }
}
