namespace Builder
{
    public abstract class PizzaBuilder
    {
        public abstract void BuildDough();
                         
        public abstract void BuildCheese();
                         
        public abstract void BuildSauce();
                         
        public abstract void BuildMeat();
                         
        public abstract void BuildToppings();
                         
        public abstract void BuildVeggies();

        public abstract Pizza GetResult();
    }
}