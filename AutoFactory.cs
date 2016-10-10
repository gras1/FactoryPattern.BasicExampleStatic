namespace FactoryPattern.BasicExample
{
    using Autos;

    public static class AutoFactory
    {
        public static IAuto CreateInstance(string carManf)
        {
            switch (carManf)
            {
                case "bmw":
                    return new Bmw();
                case "ford":
                    return new Ford();
                case "ferrari":
                    return new Ferrari();
                default:
                    return null;
            }
        }
    }
}
