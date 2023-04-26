using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bl;

public partial class TbContractItem
{
    [Key]
    [ValidateNever]
    public int ContractItemsId { get; set; }

    [ValidateNever]
    public int ItemId { get; set; }

    [ValidateNever]
    public int ContractId { get; set; }

    public virtual TbContract Contract { get; set; } = null!;

    public virtual TbItemsc Item { get; set; } = null!;
}
