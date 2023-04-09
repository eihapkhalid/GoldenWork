using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class ClsTbMaintenanceServicesItem : IBusinessLayer<TbMaintenanceServicesItem>
    {
        FireSystemContractsDbContext context;
        public ClsTbMaintenanceServicesItem(FireSystemContractsDbContext ctx)
        {
            context = ctx;
        }
        public bool Delete(int id)
        {
            try
            {
                var contract = GetById(id);
                context.TbMaintenanceServicesItems.Remove(contract);

                context.SaveChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }

        public List<TbMaintenanceServicesItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public TbMaintenanceServicesItem GetById(int id)
        {
            try
            {
                var contract = context.TbMaintenanceServicesItems.FirstOrDefault(a => a.MaintenanceId == id);
                return contract;
            }
            catch
            {
                return new TbMaintenanceServicesItem();
            }
        }

        public bool save(TbMaintenanceServicesItem table)
        {
            try
            {

                if (table.MaintenanceId == 0)
                {
                 //  ttable.FirstParty = "مؤسسة العمل الذهبي للمقاولات";
                   // ttable.CreatedBy = "ايهاب خالد ";
                 // table.CreatedDate = DateTime.Now;

                }
                else
                {
                    context.Entry(table).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<TbMaintenanceServicesItem> VwGetALL()
        {
            throw new NotImplementedException();
        }

        public List<TbMaintenanceServicesItem> VwGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
