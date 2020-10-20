namespace FactoryMethod
{
    public class HatchbackCreator : CarCreator
    {
        protected override Car CreateCar()
        {
            return new Hatchback();
        }
    }
}
