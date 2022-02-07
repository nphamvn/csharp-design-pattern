public class WarmingFactory : AirConditionerFactory
{
    public override IAirConditioner Create(double temperature)
    {
        return new WarmingManager(temperature);
    }
}