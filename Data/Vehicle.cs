using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProtectiveVehiclemanagementMVC.Data;

public partial class Vehicle
{
    [Display(Name ="Vehicle Number")]
    public string VehicleNum { get; set; } = null!;

    [Display(Name ="Vehicle Type")]
    public string VehicleType { get; set; } = null!;

    [Display(Name ="Date Added")]
    public DateTime? DateAdded { get; set; }

    [Display(Name ="Current Milage")]
    public int CurrentMilage { get; set; }

    [Display(Name ="Current Hours")]
    public int CurrentHours { get; set; }

    [Display(Name ="Last Service")]
    public int PreviousHours { get; set; }

    [Display(Name ="Next Service")]
    public int NextServ { get; set; }

    [Display(Name ="Status")]
    public string VehicleStatus { get; set; } = null!;
}
