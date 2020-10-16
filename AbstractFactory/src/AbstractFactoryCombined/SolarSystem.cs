using System;

namespace AbstractFactoryCombined
{
    public class SolarSystem : ISolarSystem
    {
        private readonly Planet planet;
        private readonly Star star;

        public SolarSystem(IGalaxyFactory galaxyFactory)
        {
            if (galaxyFactory == null) throw new ArgumentNullException();

            planet = galaxyFactory.CreatePlanet();
            star = galaxyFactory.CreateStar();
        }

        public void Orbit()
        {
            planet.Revolve(star);
        }
    }
}
