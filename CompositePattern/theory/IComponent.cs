namespace theory
{
    // Commun interface
    public interface IComponent<T> where T : class
    {
        // Add item in component
        void Add(IComponent<T> item);

        // Display item and childs
        void Display();

        // Gets name of the component
        T Name {get;set;}
    }
}