using System;

namespace realexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(100);
            Robot robot = new Robot(10);
            Robot robot2 = new Robot(12);
            Robot robot3 = new Robot(15);

            ship.Fly();

            ship.Add(robot);
            ship.Add(robot2);
            ship.Add(robot3);

            ship.Fly();
        }
    }
}
