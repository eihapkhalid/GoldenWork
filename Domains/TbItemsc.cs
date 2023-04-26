using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bl;

public partial class TbItemsc
{
    [Key]
    [ValidateNever]
    public int ItemId { get; set; }

    [Required(ErrorMessage = "Please enter an ItemName.")]
    [StringLength(50, ErrorMessage = "ItemName  must be less than 50 characters.")]
    public string ItemName { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public virtual ICollection<TbContractItem> TbContractItems { get; } = new List<TbContractItem>();
}
