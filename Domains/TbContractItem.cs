using System;
using System.Collections.Generic;

namespace Bl;

public partial class TbContractItem
{
    public int ContractItemsId { get; set; }

    public int ItemId { get; set; }

    public int ContractId { get; set; }

    public virtual TbContract Contract { get; set; } = null!;

    public virtual TbItemsc Item { get; set; } = null!;
}
