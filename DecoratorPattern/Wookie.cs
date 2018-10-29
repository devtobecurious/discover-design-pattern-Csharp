using System;

namespace DecoratorPattern
{
    public class Wookie
    {
        #region Fields
        private static Random __rand = new Random();
        private IPulling _weapon = null;
        #endregion

        #region Constructors
        public Wookie(IPulling weapon)
        {
            this._weapon = weapon;
        }
        #endregion
        
        #region Public methods
        public void Shoot()
        {
            // Guess we have a map in 2D
            int x = __rand.Next(0, 100);
            int y = __rand.Next(0, 100);

            this._weapon.Pull(x, y);

            //Here, we use a new decorator :)
            IPulling laserPulling = new LaserGunDecorator(this._weapon);
            laserPulling.Pull(x, y);

            // And voila :D
        }
        #endregion
    }
}