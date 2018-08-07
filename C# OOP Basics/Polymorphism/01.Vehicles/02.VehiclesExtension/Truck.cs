public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumptionLperKm, double tankCapacity)
        : base(fuelQuantity, fuelConsumptionLperKm, tankCapacity) { }

    public override double FuelConsumptionLperKm
    {
        get => base.FuelConsumptionLperKm + 1.6;
    }

    public override void Refuel(double litersToRefuel)
    {
        this.FuelQuantity += litersToRefuel * 0.95;
    }
}

