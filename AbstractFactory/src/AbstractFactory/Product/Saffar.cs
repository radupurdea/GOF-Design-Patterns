using System;

namespace AbstractFactory
{
    public sealed class Saffar : Planet
    {
        public Saffar()
            : base("Upsilon Andromedae b (Saffar)")
        {
        }

        public override void Revolve(Star star)
        {
            if (star == null) throw new ArgumentNullException();

            Console.WriteLine($"The exoplanet {this.Name} is believed to be revolving around the {star.Name} star.");
        }
    }
}