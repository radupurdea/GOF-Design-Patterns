namespace AbstractFactoryCombined
{
    public sealed class MilkyWayFactory : GalaxyFactory
    {
        public override Planet CreatePlanet()
        {
            return new Earth();
        }

        public override Star CreateStar()
        {
            return new Sun();
        }
    }
}
