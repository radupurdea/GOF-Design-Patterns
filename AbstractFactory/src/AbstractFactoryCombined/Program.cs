using Microsoft.Extensions.DependencyInjection;

namespace AbstractFactoryCombined
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //TODO: Implement builder and prototype when actually create the objects

            //combined with IoC and Singleton
            var serviceProvider = new ServiceCollection()
               .AddSingleton<IGalaxyFactory, MilkyWayFactory>()
               .AddTransient<ISolarSystem, SolarSystem>()
               .BuildServiceProvider();
            
            var galaxyFactory = serviceProvider.GetService<ISolarSystem>();
            galaxyFactory.Orbit();

            //TODO: For real life sample, use pizza example from here: https://web.cs.dal.ca/~jin/3132/lectures/dp-08.pdf
        }
    }
}
