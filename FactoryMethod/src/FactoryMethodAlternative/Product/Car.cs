using System;

namespace FactoryMethodAlternative
{
    public class Car
    {
        protected Car() // Use Static Factory method instead of constructor
        {
            Console.WriteLine("Created a brand new {0}", this.GetType().Name);
        }

        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
        public HandednessOfRoad HandednessOfRoad { get; set; }

        public static Car Create() // A static factory method
        {
            return new Car();
        }

        public static Car CreateWithHandednessOfRoad(HandednessOfRoad handednessOfRoad) // A static factory method with arguments for constructor
        {
            var car = new Car()
            {
                HandednessOfRoad = handednessOfRoad
            };

            Console.WriteLine("     Assembled {0} doors and {1} seats for {2} roads.",
                  car.NumberOfDoors,
                  car.NumberOfSeats,
                  car.HandednessOfRoad); // Note we do not use the keyword 'this' here to access properties

            return car;
        }

        public static Car CreateAsSedan() // A static factory method, creating a subclass
        {
            return new Sedan();
        }

        public static Car CreateAsMicro()
        {
            return new Micro();
        }

        public static Car CreateAsHatchback()
        {
            return new Hatchback();
        }
    }
}