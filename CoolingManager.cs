public class CoolingManager : IAirConditioner
{
    private readonly double _temperature;

    public CoolingManager(double temperature)
    {
        _temperature = temperature;
    }

    public void Operate()
    {
        // Cooling logic
        Console.WriteLine($"Cooling the room to the required temperature of {_temperature} degrees");
    }
}