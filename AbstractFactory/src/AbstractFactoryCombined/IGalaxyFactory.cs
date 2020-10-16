namespace AbstractFactoryCombined
{
    public interface IGalaxyFactory
    {
        Planet CreatePlanet();

        Star CreateStar();
    }
}