namespace realexample
{
    // Interface with provide method to get a specific weapon
    public interface IWeaponProvider
    {
        // Provides a weapon thanks to a player 
         IWeapon Provide(IPlayer player);
    }
}