using System;

namespace FactoryMethodAlternative
{
    public class Micro : Car
    {
        public Micro()
        {
            this.HandednessOfRoad = HandednessOfRoad.RightHandTraffic;
            this.NumberOfDoors = 2;
            this.NumberOfSeats = 2;

            Console.WriteLine("     Assembled {0} doors and {1} seats for {2} roads.",
                this.NumberOfDoors,
                this.NumberOfSeats,
                this.HandednessOfRoad);
        }
    }
}