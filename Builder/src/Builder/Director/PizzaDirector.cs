namespace Builder
{
    public class PizzaDirector
    {
        public void Construct(PizzaBuilder builder)
        {
            builder.BuildDough();
            builder.BuildSauce();
            builder.BuildVeggies();
            builder.BuildMeat();
            builder.BuildCheese();
            builder.BuildToppings();
        }
    }
}
