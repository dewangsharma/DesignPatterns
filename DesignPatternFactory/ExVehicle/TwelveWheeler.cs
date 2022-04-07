namespace DesignPatternFactory.ExVehicle
{
    internal class TwelveWheeler: Vehicle
    {
        internal override string Name { get; set; }
        internal override string Registration { get; set; }
        internal override double EngineSize { get; set; }

        internal TwelveWheeler(string name, string regNumber, double engineSize)
        {
            Name = name;
            Registration = regNumber;
            EngineSize = engineSize;
        }

        internal override string Drive()
            => "Tweleve wheel vehicle drives";
    }
}
