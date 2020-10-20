using System;

namespace FactoryMethodAlternative
{
    public class Hatchback : Car
    {
        public Hatchback()
        {
            this.HandednessOfRoad = HandednessOfRoad.LeftHandTraffic;
            this.NumberOfDoors = 5;
            this.NumberOfSeats = 5;

            Console.WriteLine("     Assembled {0} doors and {1} seats for {2} roads.",
                this.NumberOfDoors,
                this.NumberOfSeats,
                this.HandednessOfRoad);
        }
    }
}