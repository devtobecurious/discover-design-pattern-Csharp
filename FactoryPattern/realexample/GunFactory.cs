namespace realexample
{
    public static class GunFactory
    {
        public static IGun CreateOne(int level)
        {
            IGun gun = null;

            switch(level)
            {
                case 1:
                {
                    gun = new WeekGun();
                }break;

                case 2:
                {
                    gun = new BigGun();
                }break;
            }

            return gun;
        }
    }
}