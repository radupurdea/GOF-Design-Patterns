using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class Pizza
    {
        private readonly string name;
        private readonly IDictionary<string, List<string>> parts = 
            new Dictionary<string, List<string>>()
            {
                { "Dough", new List<string>() },
                { "Sauce", new List<string>() },
                { "Veggies", new List<string>() },
                { "Meat", new List<string>() },
                { "Cheese", new List<string>() },
                { "Toppings", new List<string>() },
            };

        public Pizza(string name)
        {
            this.name = name;
        }

        public void Add(string partLayer, params string[] parts)
        {
            this.parts[partLayer].AddRange(parts);
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder(this.name);

            stringBuilder.AppendLine();

            foreach(var part in this.parts)
            {
                if(part.Value.Any())
                {
                    stringBuilder.AppendLine(string.Format("{0}:", part.Key));

                    stringBuilder.AppendLine(string.Format("    {0}", string.Join(", ", part.Value)));
                }
            }

            return stringBuilder.ToString();
        }
    }
}