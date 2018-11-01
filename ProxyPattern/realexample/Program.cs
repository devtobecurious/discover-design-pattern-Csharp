using System;

namespace realexample
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayer player = new DefaultPlayer() { CurrentLevel = 1, Name = "Luke" };

            IWeaponProvider provider = new WeaponControlProvider();
            IWeapon weapon = provider.Provide(player);

            weapon.Shoot();

            player = new DefaultPlayer() { CurrentLevel = 2, Name = "Jabba" };
            weapon = provider.Provide(player);

            weapon.Shoot();
        }
    }
}
