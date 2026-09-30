using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JohnsGarage.Models;

public class Customer
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Email { get; set; } = "";
    public string AddressLine1 { get; set; } = "";
    public string AddressLine2 { get; set; } = "";
    public string City { get; set; } = "";
    public string State { get; set; } = "";
    public string ZipCode { get; set; } = "";
    public string PreferredContactMethod { get; set; } = "Phone";
    public string Preferences { get; set; } = "";
    public string Notes { get; set; } = "";
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public List<Vehicle> Vehicles { get; set; } = new();

    [NotMapped]
    public string FullName =>
        string.IsNullOrWhiteSpace($"{FirstName} {LastName}".Trim())
            ? "Unnamed Customer"
            : $"{FirstName} {LastName}".Trim();
}
