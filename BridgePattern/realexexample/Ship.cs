namespace realexexample
{
    // A ship in space, to be used by Chewie :)
    public class Ship
    {
        #region Fields   
        #endregion
        
        #region  Constructors
        public Ship(Gun gun)
        {
            this.CurrentGun = gun;
            this.EnergyPower = 100; // Here, default max value
        }
        #endregion

        #region Public methods
        public void Attack(Ship ship)
        {
            int powerToAttack = this.CurrentGun.Shoot();

            System.Console.WriteLine($"Le vaisse actuel attaque avec un niveau de {powerToAttack} !");
            ship.EnergyPower -= powerToAttack;

            System.Console.WriteLine($"Vaisseau actuel : {this.EnergyPower} XP");
            System.Console.WriteLine($"Vaisseau ennemi : {ship.EnergyPower} XP");
        }
        #endregion

        #region Properties
        // Here, it simulates the power of the energy of the ship
        public int EnergyPower {get;set;}

        // Alolows you to change gun, when you want
        public Gun CurrentGun {get;set;}
        #endregion
    }
}