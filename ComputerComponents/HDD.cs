
using System;

namespace ComputerComponents
{
    public class HDD : Component, IInstallable
    {
        public int Capacity { get; set; }

        public HDD(string name, decimal price, int capacity)
            : base(name, price)
        {
            Capacity = capacity;
        }

        public override void GetInfo()
        {
            Console.WriteLine(
                $"HDD: {Name}, Capacity: {Capacity} GB, Price: {Price} $");
        }

        public void Install()
        {
            Console.WriteLine($"Installing HDD: {Name}");
        }

        public static bool operator ==(HDD a, HDD b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.Name == b.Name && a.Price == b.Price;
        }

        public static bool operator !=(HDD a, HDD b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return obj is HDD other && this == other;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }
    }
}
