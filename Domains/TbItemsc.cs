using System;
using System.Collections.Generic;

namespace Bl;

public partial class TbItemsc
{
    public int ItemId { get; set; }

    public string ItemName { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public virtual ICollection<TbContractItem> TbContractItems { get; } = new List<TbContractItem>();
}
