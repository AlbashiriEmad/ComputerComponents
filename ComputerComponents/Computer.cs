
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerComponents
{
    public class Computer
    {
        private List<Component> components = new List<Component>();

        public void AddComponent<T>(T component)
            where T : Component, IInstallable
        {
            components.Add(component);
            component.Install();
            Console.WriteLine($"{component.Name} added to computer.");
        }

        public void RemoveComponent<T>(T component)
            where T : Component
        {
            if (components.Remove(component))
            {
                Console.WriteLine($"{component.Name} removed from computer.");
            }
            else
            {
                Console.WriteLine("Component not found.");
            }
        }

        public decimal GetTotalPrice()
        {
            return components.Sum(component => component.Price);
        }

        public void ShowComponents()
        {
            Console.WriteLine("\nComputer components:");

            foreach (Component component in components)
            {
                component.GetInfo();
            }
        }
    }
}
