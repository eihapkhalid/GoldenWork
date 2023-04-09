using System;
using System.Collections.Generic;

namespace Bl;

public partial class TbMaintenanceServicesItem
{
    public int ServicesItemsId { get; set; }

    public int MaintenanceId { get; set; }

    public int MaintenanceItemsId { get; set; }

    public int Quantity { get; set; }

    public virtual TbMaintenanceService Maintenance { get; set; } = null!;

    public virtual TbMaintenanceItem ServicesItems { get; set; } = null!;
}
