namespace FactoryMethod
{
    public class SedanCreator : CarCreator
    {
        protected override Car CreateCar()
        {
            return new Sedan();
        }
    }
}
