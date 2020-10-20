namespace FactoryMethod
{
    public class Hatchback : Car
    {
        public override HandednessOfRoad GetHandednessOfRoad()
        {
            return HandednessOfRoad.LeftHandTraffic;
        }

        public override int GetNumberOfDoors()
        {
            return 5;
        }

        public override int GetNumberOfSeats()
        {
            return 5;
        }
    }
}
