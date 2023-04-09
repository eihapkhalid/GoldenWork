using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bl.Migrations
{
    /// <inheritdoc />
    public partial class VwContractMaintnceServices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create view VwContractMaintnceServices as 
                                   SELECT        dbo.TbMaintenanceItems.ItemName, dbo.TbContracts.ContractDate, dbo.TbContracts.ContractType, dbo.TbContracts.SecondParty, dbo.TbContracts.CreatedBy, dbo.TbContracts.CreatedDate, dbo.TbContracts.Price, 
                         dbo.TbMaintenanceServices.ServiceType, dbo.TbMaintenanceServices.SecondPartyLocation, dbo.TbMaintenanceServicesItems.Quantity
FROM            dbo.TbContracts INNER JOIN
                         dbo.TbMaintenanceServicesItems INNER JOIN
                         dbo.TbMaintenanceItems ON dbo.TbMaintenanceServicesItems.ServicesItemsId = dbo.TbMaintenanceItems.MaintenanceItemsId INNER JOIN
                         dbo.TbMaintenanceServices ON dbo.TbMaintenanceServicesItems.MaintenanceID = dbo.TbMaintenanceServices.MaintenanceID ON dbo.TbContracts.MaintenanceID = dbo.TbMaintenanceServices.MaintenanceID");       }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
