using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bl;

public partial class TbMaintenanceItem
{
    [Key]
    [ValidateNever]
    public int MaintenanceItemsId { get; set; }

    [Required(ErrorMessage = "Please enter the Item Name.")]
    [StringLength(100, ErrorMessage = "Item Name name must be less than 100 characters.")]
    public string ItemName { get; set; } = null!;

    [Required(ErrorMessage = "Please enter the Item Description.")]
    [StringLength(100, ErrorMessage = "Item Description Type name must be less than 100 characters.")]
    public string? ItemDescription { get; set; }

    public virtual TbMaintenanceServicesItem? TbMaintenanceServicesItem { get; set; }
}
