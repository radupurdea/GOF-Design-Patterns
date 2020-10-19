namespace Builder
{
    public class TexasBbqPizzaBuilder : PizzaBuilder
    {
        private readonly Pizza pizza;

        public TexasBbqPizzaBuilder()
        {
            this.pizza = new Pizza("Texas BBQ Chicken");
        }

        public override void BuildCheese()
        {
            this.pizza.Add("Cheese", "Cheddar");
        }

        public override void BuildDough()
        {
            this.pizza.Add("Dough", "Regular crust");
        }

        public override void BuildMeat()
        {
            this.pizza.Add("Meat", "Grilled chicken", "Bacon");
        }

        public override void BuildSauce()
        {
            this.pizza.Add("Sauce", "Barbecue");
        }

        public override void BuildVeggies()
        {
            this.pizza.Add("Veggies", "Green bell peppers", "Onions");
        }

        public override void BuildToppings()
        {
            // No toppings on this pizza
        }

        public override Pizza GetResult()
        {
            return this.pizza;
        }
    }
}
