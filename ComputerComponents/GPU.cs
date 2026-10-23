
using System;

namespace ComputerComponents
{
    public class GPU : Component, IInstallable
    {
        public int Memory { get; set; }

        public GPU(string name, decimal price, int memory)
            : base(name, price)
        {
            Memory = memory;
        }

        public override void GetInfo()
        {
            Console.WriteLine(
                $"GPU: {Name}, Memory: {Memory} GB, Price: {Price} $");
        }

        public void Install()
        {
            Console.WriteLine($"Installing GPU: {Name}");
        }

        public static bool operator ==(GPU a, GPU b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.Name == b.Name && a.Price == b.Price;
        }

        public static bool operator !=(GPU a, GPU b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return obj is GPU other && this == other;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }
    }
}
