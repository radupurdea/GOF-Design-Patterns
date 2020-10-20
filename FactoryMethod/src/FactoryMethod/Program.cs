namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new SedanCreator().MakeCar();
            new MicroCreator().MakeCar();
            new HatchbackCreator().MakeCar();
        }
    }
}
