using System;

namespace PatternFactoryMethod
{
    public abstract class Developer
    {
        public string Name { get; set; }
        public Developer(string name)
        {
            Name = name;
        }
        abstract public Application Create();
    }
}
