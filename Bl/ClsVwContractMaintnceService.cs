using Domains;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class ClsVwContractMaintnceService : IBusinessLayer<VwContractMaintnceService>
    {
        FireSystemContractsDbContext context;
        public ClsVwContractMaintnceService(FireSystemContractsDbContext ctx)
        {
            context = ctx;
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<VwContractMaintnceService> GetAll()
        {
            throw new NotImplementedException();
        }

        public VwContractMaintnceService GetById(int id)
        {
            try
            {
                var contract = context.VwContractMaintnceServices.FirstOrDefault(a => a.ContractId == id);
                return contract;
            }
            catch
            {
                return new VwContractMaintnceService();
            }
        }

        public bool save(VwContractMaintnceService table)
        {
            try
            {

                if (table.ContractId == 0)
                {
                    table.FirstParty = "مؤسسة العمل الذهبي للمقاولات";
                    table.CreatedBy = "ايهاب خالد ";
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

        public List<VwContractMaintnceService> VwGetById(int id)
        {
            try
            {
                var result = context.VwContractMaintnceServices.Where(a => a.ContractId == id).ToList();
                return result;
            }
            catch
            {
                return new List<VwContractMaintnceService>();
            }
        }

        public List<VwContractMaintnceService> VwGetALL()
        {
            try
            {
                var result = context.VwContractMaintnceServices.ToList();
                return result;
            }
            catch
            {
                return new List<VwContractMaintnceService>();
            }
        }
    }
}
