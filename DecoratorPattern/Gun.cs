namespace DecoratorPattern
{
    public class Gun : IPulling
    {
        #region Public methods
        public void Pull(int x, int y)
        {
            System.Console.WriteLine($"L'arme tire ({x}:{y}) ! Tioo Tiooo");
        }
        #endregion
    }
}