
using System;

namespace ComputerComponents
{
    public abstract class Component
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        protected Component(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Component: {Name}, Price: {Price} $");
        }

        public override string ToString()
        {
            return $"{Name} - {Price} $";
        }
    }
}
