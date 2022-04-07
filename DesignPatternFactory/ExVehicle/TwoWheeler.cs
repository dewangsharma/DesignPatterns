using System;

namespace DesignPatternFactory.ExVehicle
{
    internal class TwoWheeler: Vehicle
    {
        internal override string Name { get; set; }
        internal override string Registration { get; set; }
        internal override double EngineSize { get; set; }

        internal TwoWheeler(string name, string regNumber, double engineSize)
        {
            Name = name;
            Registration = regNumber;
            EngineSize = engineSize;
        }

        internal override string Drive()
            => "Two wheel vehicle drives";
    }
}
