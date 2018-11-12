

using System.Collections.Generic;

namespace theory
{
    // Container of component, or composite (hierarchy)
    public class Composite<T> : IComponent<T>
                 where T: class
    {
        private List<IComponent<T>> _list = null;

        public Composite(T name)
        {
            this.Name = name;
            this._list = new List<IComponent<T>>();
        }

        public void Add(IComponent<T> item)   
        {
            this._list.Add(item);
            System.Console.WriteLine($"Add {item.Name} in list");
        }

        public void Display()
        {
            System.Console.WriteLine($"Me: {this.Name}");
            foreach(var item in this._list)
            {
                item.Display();
            }
        }

        public T Name {get;set;}
    }
}