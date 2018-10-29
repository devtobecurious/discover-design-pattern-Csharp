namespace DecoratorPattern
{
    public class Gun : IPulling
    {
        #region Public methods
        public void Pull(int x, int y)
        {
            System.Console.WriteLine($"The gun shoot ({x}:{y}) ! Tioo Tiooo");
        }
        #endregion
    }
}