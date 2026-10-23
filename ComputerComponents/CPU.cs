
using System;

namespace ComputerComponents
{
    public class CPU : Component, IInstallable
    {
        public int Cores { get; set; }

        public CPU(string name, decimal price, int cores)
            : base(name, price)
        {
            Cores = cores;
        }

        public override void GetInfo()
        {
            Console.WriteLine(
                $"CPU: {Name}, Cores: {Cores}, Price: {Price} $");
        }

        public void Install()
        {
            Console.WriteLine($"Installing CPU: {Name}");
        }

        public static bool operator ==(CPU a, CPU b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.Name == b.Name && a.Price == b.Price;
        }

        public static bool operator !=(CPU a, CPU b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return obj is CPU other && this == other;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }
    }
}
