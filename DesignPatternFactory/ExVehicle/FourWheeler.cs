namespace DesignPatternFactory.ExVehicle
{
    internal class FourWheeler : Vehicle
    {
        internal override string Name { get; set; }
        internal override string Registration { get ; set ; }
        internal override double EngineSize { get; set; }

        internal FourWheeler(string name, string regNumber, double engineSize)
        {
            Name = name;
            Registration = regNumber;
            EngineSize = engineSize;
        }

        internal override string Drive()
            => "Four wheel vehicle drives";
    }
}
