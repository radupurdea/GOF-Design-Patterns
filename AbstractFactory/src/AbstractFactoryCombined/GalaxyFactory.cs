namespace AbstractFactoryCombined
{
    public abstract class GalaxyFactory : IGalaxyFactory
    {
        public abstract Planet CreatePlanet();

        public abstract Star CreateStar();
    }
}
