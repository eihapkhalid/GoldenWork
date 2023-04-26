using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bl;

public partial class TbMaintenanceService
{
    [Key]
    [ValidateNever]
    public int MaintenanceId { get; set; }

    [Required(ErrorMessage = "Please enter the Service Type.")]
    [StringLength(100, ErrorMessage = "Service Type name must be less than 100 characters.")]
    public string ServiceType { get; set; } = null!;

    [Required(ErrorMessage = "Please enter the Second Party Location.")]
    [StringLength(100, ErrorMessage = "Second Party Locationname must be less than 100 characters.")]
    public string SecondPartyLocation { get; set; } = null!;

    public virtual ICollection<TbContract> TbContracts { get; } = new List<TbContract>();

    public virtual ICollection<TbMaintenanceServicesItem> TbMaintenanceServicesItems { get; } = new List<TbMaintenanceServicesItem>();
}
