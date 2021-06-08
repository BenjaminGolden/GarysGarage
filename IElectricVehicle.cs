using System;

public interface IElectricVehicle
{
    int CurrentChargePercentage { get; set; }
    double BatteryKWh { get; set; }

    void ChargeBattery();
}