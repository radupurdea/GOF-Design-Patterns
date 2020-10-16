namespace AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ourGalaxyFactory = new MilkyWayFactory();
            var solarSystemClient = new SolarSystem(ourGalaxyFactory);

            solarSystemClient.Orbit();

            var otherGalaxyFactory = new AndromedaFactory();
            var extraSolarSystemClient = new SolarSystem(otherGalaxyFactory);

            extraSolarSystemClient.Orbit();
        }
    }
}
