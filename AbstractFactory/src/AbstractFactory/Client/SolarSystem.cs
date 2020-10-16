using System;

namespace AbstractFactory
{
    public class SolarSystem
    {
        private readonly Planet planet;
        private readonly Star star;

        public SolarSystem(GalaxyFactory galaxyFactory)
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
