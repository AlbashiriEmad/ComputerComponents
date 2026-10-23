
using System;

namespace ComputerComponents
{
    public class RAM : Component, IInstallable
    {
        public int Capacity { get; set; }

        public RAM(string name, decimal price, int capacity)
            : base(name, price)
        {
            Capacity = capacity;
        }

        public override void GetInfo()
        {
            Console.WriteLine(
                $"RAM: {Name}, Capacity: {Capacity} GB, Price: {Price} $");
        }

        public void Install()
        {
            Console.WriteLine($"Installing RAM: {Name}");
        }

        public static bool operator ==(RAM a, RAM b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.Name == b.Name && a.Price == b.Price;
        }

        public static bool operator !=(RAM a, RAM b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return obj is RAM other && this == other;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }
    }
}
