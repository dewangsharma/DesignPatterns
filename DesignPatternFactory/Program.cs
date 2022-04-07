using DesignPatternFactory.ExVehicle;
using System;

namespace DesignPatternFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var factory = new VehicleFactory();
                Console.WriteLine("Enter number of wheels, either 2,4,6,12");
                var wheels = Console.ReadLine();
                var vehicle = factory.BuildVehicle(int.Parse(wheels));
                Console.WriteLine($"{vehicle.Name}, {vehicle.Registration}, {vehicle.EngineSize}");
                Console.WriteLine(vehicle.Drive());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch in the Main");
                Console.WriteLine(ex);
                Console.WriteLine(ex.TargetSite.ToString());
            }
            Console.ReadLine();
        }
    }
}
