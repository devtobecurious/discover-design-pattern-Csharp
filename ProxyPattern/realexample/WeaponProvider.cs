namespace realexample
{
    public class WeaponProvider : IWeaponProvider
    {
        public IWeapon Provide(IPlayer player)
        {
            return new BasicWeapon();
        }
    }
}