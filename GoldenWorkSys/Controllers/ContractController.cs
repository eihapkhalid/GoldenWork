using Bl;
using Domains;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace GoldenWorkSys.Controllers
{
	public class ContractController : Controller
	{
		IBusinessLayer<TbContract> oClsContract;
        IBusinessLayer<VwContractMaintnceService> oClsVwContractMaintnceService;
        public ContractController(IBusinessLayer<TbContract> contract, IBusinessLayer<VwContractMaintnceService> contractMaintnceService)
		{
			oClsContract = contract;
            oClsVwContractMaintnceService = contractMaintnceService;

        }


		public IActionResult Index()
		{
			return View();
		}

		public IActionResult List()
		{
			var lstContract = oClsContract.GetAll();
			return View(lstContract);
		}
		
        public IActionResult ListById(int id)
         {
            var result = oClsVwContractMaintnceService.VwGetById(id);
            return View(result);

        }
		public IActionResult ListOfContractAsTable()
		{
            var lstContract = oClsVwContractMaintnceService.VwGetALL();
            return View(lstContract);
        }
    }
}
