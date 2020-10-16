using System;

namespace AbstractFactoryCombined
{
    public sealed class Earth : Planet
    {
        public Earth() 
            : base ("Earth")
        {
        }

        public override void Revolve(Star star)
        {
            if (star == null) throw new ArgumentNullException();

            Console.WriteLine($"{this.Name} revolves around the {star.Name}.");
        }
    }
}