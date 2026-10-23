using System;

namespace ComputerComponents
{
    public static class ComputerFactory
    {
        public static Computer CreateBasicComputer()
        {
            Computer computer = new Computer();
            computer.AddComponent(new CPU("Intel Core i5", 250m, 6));
            computer.AddComponent(new RAM("Kingston RAM", 80m, 16));
            computer.AddComponent(new GPU("NVIDIA GTX", 300m, 8));
            computer.AddComponent(new HDD("Seagate HDD", 60m, 1000));
            return computer;
        }

        public static Computer CreateGamingComputer()
        {
            Computer computer = new Computer();
            computer.AddComponent(new CPU("AMD Ryzen 9", 500m, 16));
            computer.AddComponent(new RAM("Corsair Vengeance", 150m, 32));
            computer.AddComponent(new GPU("NVIDIA RTX 4090", 1500m, 24));
            computer.AddComponent(new HDD("Samsung SSD NVMe", 200m, 2000));
            return computer;
        }
    }
}