namespace DecoratorPattern
{
    public class LaserGunDecorator : IPulling
    {
        #region Fields
        private IPulling _objectToDecorate = null;
        #endregion

        #region Constructors
        public LaserGunDecorator(IPulling objectToDecorate)
        {
            this._objectToDecorate = objectToDecorate;
        }
        #endregion

        #region Public methods
        public void Pull(int x, int y)
        {
            this._objectToDecorate.Pull(x, y);

            System.Console.WriteLine("The gun shoot with laser too ! :D");
        }
        #endregion
    }
}