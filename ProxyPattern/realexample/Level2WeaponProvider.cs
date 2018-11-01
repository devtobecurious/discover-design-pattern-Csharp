namespace realexample
{
    // Level up to get the new weapon
    public class Level2WeaponProvider : IWeaponProvider
    {
        public IWeapon Provide(IPlayer player)
        {
            return new SuperWeapon();
        }
    }
}