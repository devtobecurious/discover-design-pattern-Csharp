namespace realexexample
{
    //A gun, used by Ship
    public class Gun : IShooting
    {
        #region Fields
        private IWithLaser _laser = null;
        #endregion

        #region Constructors
        public Gun(IWithLaser laser)
        {
            this._laser = laser;
        }
        #endregion

        #region Public methods
        public int Shoot()
        {
            System.Console.WriteLine("I'm waiting to shoot the sherif :p");

            return this._laser.GenerateEnergy();
        }
        #endregion
    }
}