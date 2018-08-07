public class Car : Vehicle
{
    
    public Car(double fuelQuantity, double fuelConsumptionLperKm)
        : base(fuelQuantity, fuelConsumptionLperKm) { }

    public override double FuelConsumptionLperKm
    {

        get => base.FuelConsumptionLperKm + 0.9;
    }

}

