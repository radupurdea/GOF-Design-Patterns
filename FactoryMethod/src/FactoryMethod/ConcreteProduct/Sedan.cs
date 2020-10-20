namespace FactoryMethod
{
    public class Sedan : Car
    {
        public override HandednessOfRoad GetHandednessOfRoad()
        {
            return HandednessOfRoad.LeftHandTraffic;
        }

        public override int GetNumberOfDoors()
        {
            return 4;
        }

        public override int GetNumberOfSeats()
        {
            return 5;
        }
    }
}
