using System;

namespace JohnsGarage.Models;

public class Part
{
    public int PartId { get; set; }
    public int RepairOrderId { get; set; }
    public RepairOrder? RepairOrder { get; set; }
    public string PartNumber { get; set; } = "";
    public string Description { get; set; } = "";
    public string Vendor { get; set; } = "";
    public decimal QuantityQuoted { get; set; } = 1;
    public decimal UnitCostQuoted { get; set; }
    public decimal QuantityInstalled { get; set; }
    public decimal UnitCostInstalled { get; set; }
    public DateTime? DateQuoted { get; set; }
    public DateTime? DateOrdered { get; set; }
    public DateTime? DateReceived { get; set; }
    public DateTime? DateInstalled { get; set; }
    public string Warranty { get; set; } = "";
    public string Notes { get; set; } = "";

    public decimal QuotedTotal => QuantityQuoted * UnitCostQuoted;
    public decimal InstalledTotal => QuantityInstalled > 0
        ? QuantityInstalled * (UnitCostInstalled > 0 ? UnitCostInstalled : UnitCostQuoted)
        : QuotedTotal;
}
