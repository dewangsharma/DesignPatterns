namespace DesignPatternFactory.ExVehicle
{
    internal abstract class Vehicle
    {
        abstract internal string Name { get; set; }
        abstract internal string Registration { get; set; }
        abstract internal double EngineSize { get; set; }
        abstract internal string Drive();
    }
}
