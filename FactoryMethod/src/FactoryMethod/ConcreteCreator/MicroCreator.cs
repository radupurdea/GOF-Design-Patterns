namespace FactoryMethod
{
    public class MicroCreator : CarCreator
    {
        protected override Car CreateCar()
        {
            return new Micro();
        }
    }
}
