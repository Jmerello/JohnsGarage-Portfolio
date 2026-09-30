using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JohnsGarage.Models;

public class Vehicle
{
    public int VehicleId { get; set; }
    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }
    public int Year { get; set; }
    public string Make { get; set; } = "";
    public string Model { get; set; } = "";
    public string Trim { get; set; } = "";
    public string VIN { get; set; } = "";
    public string LicensePlate { get; set; } = "";
    public string PlateState { get; set; } = "";
    public int Mileage { get; set; }
    public string Engine { get; set; } = "";
    public string Transmission { get; set; } = "";
    public string Drivetrain { get; set; } = "";
    public string Color { get; set; } = "";
    public string Notes { get; set; } = "";
    public List<RepairOrder> RepairOrders { get; set; } = new();

    [NotMapped]
    public string DisplayName =>
        string.IsNullOrWhiteSpace($"{Year} {Make} {Model} {Trim}".Trim())
            ? "Unnamed Vehicle"
            : $"{Year} {Make} {Model} {Trim}".Trim();
}
