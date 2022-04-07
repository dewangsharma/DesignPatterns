namespace DesignPatternFactory.ExVehicle
{
    internal class SixWheeler: Vehicle
    {
        internal override string Name { get; set; }
        internal override string Registration { get; set; }
        internal override double EngineSize { get; set; }

        internal SixWheeler(string name, string regNumber, double engineSize)
        {
            Name = name;
            Registration = regNumber;
            EngineSize = engineSize;
        }

        internal override string Drive()
            => "Six wheel vehicle drives";
    }
}
