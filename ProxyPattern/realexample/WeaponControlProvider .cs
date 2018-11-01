namespace realexample
{
    // Proxy that checks rule to get the good weapon
    public class WeaponControlProvider : IWeaponProvider
    {
        IWeaponProvider _defaultProvider = null;

        #region Public methods
        public IWeapon Provide(IPlayer player)
        {
            this.CheckRights(player);

            return this._defaultProvider.Provide(player);
        }
        #endregion
        
        #region Internal methods
        // Note : we will be able to get a rules manager here
        private void CheckRights(IPlayer player)
        {
            if(player.CurrentLevel == 1)
                this._defaultProvider = new WeaponProvider();
            else
                this._defaultProvider = new Level2WeaponProvider();
        }
        #endregion
    }
}