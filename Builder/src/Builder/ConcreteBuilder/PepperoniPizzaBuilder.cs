namespace Builder
{
    public class PepperoniPizzaBuilder : PizzaBuilder
    {
        private readonly Pizza pizza;

        public PepperoniPizzaBuilder()
        {
            this.pizza = new Pizza("Pepperoni");
        }

        public override void BuildCheese()
        {
            this.pizza.Add("Cheese", "Mozzarella");
        }

        public override void BuildDough()
        {
            this.pizza.Add("Dough", "Thin crust");
        }

        public override void BuildMeat()
        {
            this.pizza.Add("Meat", "Pepperoni");
        }

        public override void BuildSauce()
        {
            this.pizza.Add("Sauce", "Tomato");
        }

        public override void BuildVeggies()
        {
            this.pizza.Add("Veggies", "Pitted olives", "Cherry tomatoes", "Garlic clove");
        }

        public override void BuildToppings()
        {
            this.pizza.Add("Toppings", "Oregano", "Basil leaves", "Grated Parmezan Cheese");
        }

        public override Pizza GetResult()
        {
            return this.pizza;
        }
    }
}
