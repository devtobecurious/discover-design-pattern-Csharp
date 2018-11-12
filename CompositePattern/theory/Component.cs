namespace theory
{
    // One item, added in Composite class
    public class Component<T> : IComponent<T>
                 where T: class
    {
        public Component(T name)
        {
            this.Name = name;
        }

        public void Add(IComponent<T> item)   
        {
            System.Console.WriteLine($"Add item {Name}");
        }

        public void Display()
        {
            System.Console.WriteLine($"Me: {this.Name}");
        }

        public T Name {get;set;}
    }
}