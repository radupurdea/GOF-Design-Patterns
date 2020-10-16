using System;

namespace AbstractFactory
{
    public abstract class Planet
    {
        public string Name { get; }

        public Planet(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();

            this.Name = name;
        }
        
        public abstract void Revolve(Star star);
    }
}