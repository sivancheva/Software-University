public class Car : Vehicle
{
    
    public Car(double fuelQuantity, double fuelConsumptionLperKm, double tankCapacity)
        : base(fuelQuantity, fuelConsumptionLperKm, tankCapacity) { }

    public override double FuelConsumptionLperKm
    {

        get => base.FuelConsumptionLperKm + 0.9;
    }

}

