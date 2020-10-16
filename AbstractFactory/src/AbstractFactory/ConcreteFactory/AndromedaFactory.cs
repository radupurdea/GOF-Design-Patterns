namespace AbstractFactory
{
    public sealed class AndromedaFactory : GalaxyFactory
    {
        public override Planet CreatePlanet()
        {
            return new Saffar();
        }

        public override Star CreateStar()
        {
            return new UpsilonAndromedae();
        }
    }
}
