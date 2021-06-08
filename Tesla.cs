namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; } = 100;

        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}