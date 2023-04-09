using System;
using System.Collections.Generic;

namespace Bl;

public partial class TbContract
{
    public int ContractId { get; set; }

    public DateTime ContractDate { get; set; }

    public string ContractType { get; set; } = null!;

    public string FirstParty { get; set; } = null!;

    public string SecondParty { get; set; } = null!;

    public int? MaintenanceId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public decimal Price { get; set; }

    public virtual TbMaintenanceService? Maintenance { get; set; }

    public virtual ICollection<TbContractItem> TbContractItems { get; } = new List<TbContractItem>();
}
