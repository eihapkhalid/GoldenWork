using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class VwContractMaintnceService
    {
        
        public int ContractId { get; set; }

        public DateTime ContractDate { get; set; }

        public string ContractType { get; set; } = null!;

        public string FirstParty { get; set; } = null!;

        public string SecondParty { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        /// <summary>
        /// ////
        /// </summary>

        public string ServiceType { get; set; } = null!;

        public string SecondPartyLocation { get; set; } = null!;

        /// <summary>
        /// /
        /// </summary>


        public int Quantity { get; set; }

        // public int? MaintenanceId { get; set; }

        public string ItemName { get; set; } = null!;

        public decimal Price { get; set; }
    }
}
