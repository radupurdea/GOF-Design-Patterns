namespace AbstractFactory
{
    public abstract class GalaxyFactory
    {
        public abstract Planet CreatePlanet();

        public abstract Star CreateStar();
    }
}
