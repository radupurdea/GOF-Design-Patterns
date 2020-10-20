namespace FactoryMethodAlternative
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var blankCar = Car.Create();
            var rightHandedCar = Car.CreateWithHandednessOfRoad(HandednessOfRoad.RightHandTraffic);
            var sedanCar = Car.CreateAsSedan();
            var hatchbackCar = Car.CreateAsHatchback();
            var microCar = Car.CreateAsMicro();
        }
    }
}
