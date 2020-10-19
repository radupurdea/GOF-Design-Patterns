using System;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pizzaDirector = new PizzaDirector();
            var pepperoniPizzaBuilder = new PepperoniPizzaBuilder();

            pizzaDirector.Construct(pepperoniPizzaBuilder);

            var pepperoniPizza = pepperoniPizzaBuilder.GetResult();

            Console.WriteLine(pepperoniPizza);

            var texasBbqPizzaBuilder = new TexasBbqPizzaBuilder();

            pizzaDirector.Construct(texasBbqPizzaBuilder);

            var texasBbqPizza = texasBbqPizzaBuilder.GetResult();

            Console.WriteLine(texasBbqPizza);
        }
    }
}
