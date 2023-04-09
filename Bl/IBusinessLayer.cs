using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
	public interface IBusinessLayer<t>
	{
		public List<t> GetAll();
		public t GetById(int id);
		public bool save(t table);
		public bool Delete(int id);
        public List<t> VwGetById(int id);
        public List<t> VwGetALL();
    }
}
