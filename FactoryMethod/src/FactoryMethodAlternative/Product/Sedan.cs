using System;

namespace FactoryMethodAlternative
{
    public class Sedan : Car
    {
        public Sedan()
        {
            this.HandednessOfRoad = HandednessOfRoad.LeftHandTraffic;
            this.NumberOfDoors = 4;
            this.NumberOfSeats = 4;

            Console.WriteLine("     Assembled {0} doors and {1} seats for {2} roads.",
                this.NumberOfDoors,
                this.NumberOfSeats,
                this.HandednessOfRoad);
        }
    }
}