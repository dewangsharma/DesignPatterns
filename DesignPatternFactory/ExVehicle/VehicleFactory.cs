using System;

namespace DesignPatternFactory.ExVehicle
{
    internal class VehicleFactory
    {
        internal Vehicle BuildVehicle( int wheels)
        {
            try
            {
                if (wheels == 2)
                    return new TwoWheeler("Honda", "MP09 1234", 600);

                if (wheels == 4)
                    return new FourWheeler("Hundai", "MP09 0909", 900);

                if (wheels == 6)
                    return new SixWheeler("Tata", "MP11 7890", 1200);

                if (wheels == 12)
                    return new TwelveWheeler("L&T", "MP11 1234", 1800);

                throw new NotImplementedException($"Vehicle type for wheels {wheels} is not implemented");
            } 
            catch (Exception)
            {
                Console.WriteLine("Catch in the Vehicle Build");
                throw;
            }
        }
    }
}
