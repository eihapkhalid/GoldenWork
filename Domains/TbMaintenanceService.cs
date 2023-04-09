using System;
using System.Collections.Generic;

namespace Bl;

public partial class TbMaintenanceService
{
    public int MaintenanceId { get; set; }

    public string ServiceType { get; set; } = null!;

    public string SecondPartyLocation { get; set; } = null!;

    public virtual ICollection<TbContract> TbContracts { get; } = new List<TbContract>();

    public virtual ICollection<TbMaintenanceServicesItem> TbMaintenanceServicesItems { get; } = new List<TbMaintenanceServicesItem>();
}
