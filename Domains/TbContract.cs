using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bl
{
    public partial class TbContract
    {
        [Key]
        [ValidateNever]
        public int ContractId { get; set; }

        [Required(ErrorMessage = "Please enter a contract date.")]
        public DateTime ContractDate { get; set; }

        [Required(ErrorMessage = "Please enter a contract type.")]
        [StringLength(50, ErrorMessage = "Contract type must be less than 50 characters.")]
        public string ContractType { get; set; } = null!;

        [Required(ErrorMessage = "Please enter the first party.")]
        [StringLength(100, ErrorMessage = "First party name must be less than 100 characters.")]
        public string FirstParty { get; set; } = null!;

        [Required(ErrorMessage = "Please enter the second party.")]
        [StringLength(100, ErrorMessage = "Second party name must be less than 100 characters.")]
        public string SecondParty { get; set; } = null!;

        public int? MaintenanceId { get; set; }

        [Required(ErrorMessage = "Please enter the creator's name.")]
        [StringLength(50, ErrorMessage = "Creator's name must be less than 50 characters.")]
        public string CreatedBy { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Please enter a price.")]
        [Range(0.0000000001, 9999999.99, ErrorMessage = "Price must be between 0.0000000001 and 9999999.99.")]
        public decimal Price { get; set; }

        public virtual TbMaintenanceService? Maintenance { get; set; }

        public virtual ICollection<TbContractItem> TbContractItems { get; } = new List<TbContractItem>();
    }
}
