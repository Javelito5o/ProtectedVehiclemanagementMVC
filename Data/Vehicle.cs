using System;
using System.Collections.Generic;

namespace ProtectiveVehiclemanagementMVC.Data;

public partial class Vehicle
{
    public string VehicleNum { get; set; } = null!;

    public string VehicleType { get; set; } = null!;

    public DateTime? DateAdded { get; set; }

    public int CurrentMilage { get; set; }

    public int CurrentHours { get; set; }

    public int PreviousHours { get; set; }

    public int NextServ { get; set; }

    public string VehicleStatus { get; set; } = null!;
}
