using System;

namespace FactoryMethod
{
    public abstract class CarCreator
    {
        protected abstract Car CreateCar(); // The Factory Method

        public void MakeCar()
        {
            var car = this.CreateCar();
            var carType = car.GetType().Name;

            Console.WriteLine("Starting to create {0}.", carType);

            var handednessOfRoad = car.GetHandednessOfRoad();
            this.AssembleChassis(handednessOfRoad);

            var numberOfDoors = car.GetNumberOfDoors();
            this.InstallDoors(numberOfDoors);

            this.AddSteeringWheel(handednessOfRoad);

            var numberOfSeats = car.GetNumberOfSeats();
            this.ReserveSeats(numberOfSeats);
            this.InstallSeats(car);
            this.AddSeatbelts(numberOfSeats);

            Console.WriteLine("Successfully created a brand new {0}!", carType);
        }

        private void AddSeatbelts(int numberOfSeats)
        {
            Console.WriteLine("Adding seatbelts for {0} seats.", numberOfSeats);
        }

        private void InstallSeats(Car car)
        {
            Console.WriteLine("Installing seats for {0} type.", car.GetType().Name);
        }

        private void ReserveSeats(int numberOfSeats)
        {
            Console.WriteLine("Reserving {0} seats to be installed.", numberOfSeats);
        }

        private void AddSteeringWheel(HandednessOfRoad handednessOfRoad)
        {
            Console.WriteLine("Adding a steering wheel for {0} roads.", handednessOfRoad);
        }

        private void InstallDoors(int numberOfDoors)
        {
            Console.WriteLine("Installing {0} doors.", numberOfDoors);
        }

        private void AssembleChassis(HandednessOfRoad handednessOfRoad)
        {
            Console.WriteLine("Assembling chassis for {0} roads.", handednessOfRoad);
        }
    }
}
