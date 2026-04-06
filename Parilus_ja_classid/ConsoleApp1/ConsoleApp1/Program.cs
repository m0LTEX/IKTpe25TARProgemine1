using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()

        {
            Console.WriteLine("Car");
            Vehicle vehicle = new Vehicle();

            Vehicle vehicle2 = new Car();
            vehicle2.Name = "BMW";
            vehicle2.Speed = 120;

            Vehicle vehicle3 = new Bicycle();
            vehicle3.Name = "Trek";
            vehicle3.Speed = 20;

            vehicle.Describe();
            vehicle2.Describe();
            vehicle3.Describe();
        }
    }
}
