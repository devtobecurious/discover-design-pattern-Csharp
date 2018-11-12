using System;

namespace realexample
{
    public class Robot : IPlaner
    {
        #region Fields
        private int _power = 100;
        #endregion

        #region Constructors
        public Robot(int power)
        {
            this._power = power;
        }
        #endregion

        #region Properties        
        public int Power => this._power;
        #endregion

        #region Public methods
        public void Fly()
        {
            System.Console.WriteLine($"Let's rock, we're flying ! {this.Power}");
        }
        #endregion
    }
}