using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bl;

public partial class TbMaintenanceServicesItem
{
    [Key]
    [ValidateNever]
    public int ServicesItemsId { get; set; }

    [ValidateNever]
    public int MaintenanceId { get; set; }

    [ValidateNever]
    public int MaintenanceItemsId { get; set; }

    [Range(0, 999, ErrorMessage = "Quantity must be between 0 and 999.")]
    public int Quantity { get; set; }

    public virtual TbMaintenanceService Maintenance { get; set; } = null!;

    public virtual TbMaintenanceItem ServicesItems { get; set; } = null!;
}
