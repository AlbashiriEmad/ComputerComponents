using System;

namespace ComputerComponents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 1. Testing Basic Computer (Factory) ===");
            Computer computer = ComputerFactory.CreateBasicComputer();
            computer.ShowComponents();
            Console.WriteLine($"\nTotal Price of Basic PC: {computer.GetTotalPrice()}");

            Console.WriteLine("\n--------------------------------------------------\n");

            Console.WriteLine("=== 2. Testing ToString() explicitly ===");
            CPU testCpu = new CPU("Intel Core i7", 300m, 8);
            Console.WriteLine("Explicit ToString() output: " + testCpu.ToString());

            Console.WriteLine("\n--------------------------------------------------\n");

            Console.WriteLine("=== 3. Testing Component Equality (==) ===");
            CPU cpu1 = new CPU("Intel Core i5", 250m, 6);
            CPU cpu2 = new CPU("Intel Core i5", 250m, 6);
            Console.WriteLine($"CPU1 == CPU2 (Should be True if Equals works): {cpu1 == cpu2}");

            Console.WriteLine("\n--------------------------------------------------\n");

            Console.WriteLine("=== 4. Testing Component Removal (RemoveComponent) ===");
            CPU cpuToRemove = new CPU("Intel Core i5", 250m, 6);
            Console.WriteLine("Removing CPU...");
            computer.RemoveComponent<CPU>(cpuToRemove);

            Console.WriteLine("\nComponents after removal:");
            computer.ShowComponents();
            Console.WriteLine($"\nTotal Price after removal: {computer.GetTotalPrice()}");

            Console.WriteLine("\n--------------------------------------------------\n");

            Console.WriteLine("=== 5. Testing Custom Factory (Gaming PC) ===");
            Computer gamingPC = ComputerFactory.CreateGamingComputer();
            gamingPC.ShowComponents();
            Console.WriteLine($"\nTotal Price of Gaming PC: {gamingPC.GetTotalPrice()}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}