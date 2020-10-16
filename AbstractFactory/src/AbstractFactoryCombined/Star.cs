using System;

namespace AbstractFactoryCombined
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