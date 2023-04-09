using Domains;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
	public class ClsContract : IBusinessLayer<TbContract>
	{
		FireSystemContractsDbContext context;
		public ClsContract(FireSystemContractsDbContext ctx) 
		{
				context = ctx;
		}
		

		List<TbContract> IBusinessLayer<TbContract>.GetAll()
		{
			try
			{

				var lstContracts = context.TbContracts.ToList();
				return lstContracts;
			}
			catch
			{
				return new List<TbContract>();
			}
		}



		bool IBusinessLayer<TbContract>.save(TbContract table)
		{
			try
			{
				var lstContracts = context.TbContracts.ToList();
				if (table.ContractId == 0)
				{
					table.FirstParty = "مؤسسة العمل الذهبي للمقاولات";
					table.CreatedBy = "ايهاب خالد ";
					table.CreatedDate = DateTime.Now;
					
					context.TbContracts.Add(table);
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

		bool IBusinessLayer<TbContract>.Delete(int id)
		{
			try
			{
				var contract = context.TbContracts.FirstOrDefault(a => a.ContractId == id);
				context.TbContracts.Remove(contract);
				context.SaveChanges();
				return true;

			}
			catch
			{
				return false;
			}

		}

        //TbContract IBusinessLayer<TbContract>.GetById(int id)
        TbContract IBusinessLayer<TbContract>.GetById(int id)
        {
			try
			{
				var contract = context.TbContracts.FirstOrDefault(a => a.ContractId == id);
				return contract;
			}
			catch
			{
				return new TbContract();
			}
		}

        public List<TbContract> VwGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TbContract> VwGetALL()
        {
            throw new NotImplementedException();
        }
    }
}
