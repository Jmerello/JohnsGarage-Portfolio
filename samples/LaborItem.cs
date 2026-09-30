using System;

namespace JohnsGarage.Models;

public class LaborItem
{
    public int LaborItemId { get; set; }
    public int RepairOrderId { get; set; }
    public RepairOrder? RepairOrder { get; set; }
    public string Description { get; set; } = "";
    public decimal HoursQuoted { get; set; }
    public decimal RateQuoted { get; set; }
    public bool IsTravel { get; set; }
    public decimal HoursPerformed { get; set; }
    public decimal RatePerformed { get; set; }
    public DateTime? DateQuoted { get; set; }
    public DateTime? DatePerformed { get; set; }
    public string Notes { get; set; } = "";

    public decimal QuotedTotal => HoursQuoted * RateQuoted;
    public decimal PerformedTotal => HoursPerformed > 0
        ? HoursPerformed * (RatePerformed > 0 ? RatePerformed : RateQuoted)
        : QuotedTotal;
    public string LaborType => IsTravel ? "Travel" : "Shop";
}
