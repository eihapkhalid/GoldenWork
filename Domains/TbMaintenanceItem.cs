using System;
using System.Collections.Generic;

namespace Bl;

public partial class TbMaintenanceItem
{
    public int MaintenanceItemsId { get; set; }

    public string ItemName { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public virtual TbMaintenanceServicesItem? TbMaintenanceServicesItem { get; set; }
}
