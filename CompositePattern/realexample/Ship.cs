using System;
using System.Collections.Generic;
using System.Linq;

namespace realexample
{
    public class Ship : IPlaner
    {
        #region Fields
        private List<IPlaner> _list = null;
        private int _power;
        #endregion

        #region Constructors
        public Ship(int power)
        {
            this._power = power;
            this._list = new List<IPlaner>();
        }
        #endregion

        #region Properties
        public int Power { get => this._power + this._list.Sum(item => item.Power); }
        #endregion

        #region Public methods
        public void Add(IPlaner item)
        {
            this._list.Add(item);
            System.Console.WriteLine($"Item is ok ! Power is growing up : {this.Power} !");
        }

        public void Fly()
        {
            System.Console.WriteLine($"We fly to the power of {this.Power}");
        }
        #endregion
    }
}