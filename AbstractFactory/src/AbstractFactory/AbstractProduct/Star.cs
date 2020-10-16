using System;

namespace AbstractFactory
{
    public abstract class Star
    {
        public string Name { get; }

        public Star(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();

            this.Name = name;
        }
    }
}