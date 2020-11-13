namespace Prototype
{
    public struct Color
    {
        private string Hexadecimal;
        public string Name { get; }

        public Color(string name, string hexadecimal)
        {
            this.Name = name;
            this.Hexadecimal = hexadecimal;
        }

        public static readonly Color Red = new Color("Red", "FF0000");
        public static readonly Color Blue = new Color("Blue", "0000FF");
        public static readonly Color Green = new Color("Green", "00FF00");

    }
}