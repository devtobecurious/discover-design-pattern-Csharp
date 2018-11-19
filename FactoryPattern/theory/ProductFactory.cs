namespace theory
{
    public static class ProductFactory
    {
        public static IProduct GetOne()
        {
            return new ConcreteProduct();
        }
    }
}