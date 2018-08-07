public interface IVehicle
{
    double FuelQuantity { get; }
    double FuelConsumptionLperKm { get; }
    double TankCapacity { get; }
    void Drive(double kmToDrive);
    void Refuel(double litersToRefuel);
}

