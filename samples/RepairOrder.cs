using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace JohnsGarage.Models;

public class RepairOrder
{
    public int RepairOrderId { get; set; }
    public int VehicleId { get; set; }
    public Vehicle? Vehicle { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime? DateScheduled { get; set; }
    public DateTime? DateStarted { get; set; }
    public DateTime? DateCompleted { get; set; }
    public string Status { get; set; } = "Estimate";
    public int MileageIn { get; set; }
    public int MileageOut { get; set; }
    public string CustomerComplaint { get; set; } = "";
    public string Diagnosis { get; set; } = "";
    public string WorkPerformed { get; set; } = "";
    public string TechnicianNotes { get; set; } = "";
    public List<Part> Parts { get; set; } = new();
    public List<LaborItem> LaborItems { get; set; } = new();

    [NotMapped] public string RepairOrderNumber => $"RO-{RepairOrderId:000000}";
    [NotMapped] public decimal QuotedPartsTotal => Parts.Sum(p => p.QuotedTotal);
    [NotMapped] public decimal InstalledPartsTotal => Parts.Sum(p => p.InstalledTotal);
    [NotMapped] public decimal QuotedLaborTotal => LaborItems.Sum(l => l.QuotedTotal);
    [NotMapped] public decimal PerformedLaborTotal => LaborItems.Sum(l => l.PerformedTotal);
    [NotMapped] public decimal QuotedGrandTotal => QuotedPartsTotal + QuotedLaborTotal;
    [NotMapped] public decimal PerformedGrandTotal => InstalledPartsTotal + PerformedLaborTotal;
}
