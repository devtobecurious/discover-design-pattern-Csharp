namespace theory
{
    public class Abstraction
    {
        #region Fields
        private IBridge _bridge = null;
        #endregion

        #region Constructors
        public Abstraction(IBridge bridge)
        {
            this._bridge = bridge;
        }
        #endregion

        #region Public methods
        public string Operation()
        {
            return this._bridge.OperationImplementation();
        }
        #endregion
    }
}