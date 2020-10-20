namespace FactoryMethod
{
    public class Micro : Car
    {
        public override HandednessOfRoad GetHandednessOfRoad()
        {
            return HandednessOfRoad.RightHandTraffic;
        }

        public override int GetNumberOfDoors()
        {
            return 2;
        }

        public override int GetNumberOfSeats()
        {
            return 2;
        }
    }
}
