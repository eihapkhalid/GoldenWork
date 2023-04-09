using Bl;
using Domains;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;


namespace FireSystemContracts.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContractController : Controller
    {
        IBusinessLayer<TbContract> oClsContract;
        IBusinessLayer<VwContractMaintnceService> oClsVwContractMaintnceService;
        IBusinessLayer<TbMaintenanceServicesItem> oClsTbMaintenanceServicesItem;  
        public ContractController(IBusinessLayer<TbContract> contract, IBusinessLayer<VwContractMaintnceService> contractMaintnceService, IBusinessLayer<TbMaintenanceServicesItem> maintenanceServicesItem)
        {
            oClsContract = contract;
            oClsVwContractMaintnceService = contractMaintnceService;
            oClsTbMaintenanceServicesItem = maintenanceServicesItem;
        }

        public IActionResult List()
        {
            var lstContract = oClsVwContractMaintnceService.VwGetALL();
            return View(lstContract);
            
        }

        public IActionResult Edit(int? contractid)
        {
            var dataContract = new VwContractMaintnceService();
            if (contractid != null)
            {
                 dataContract = oClsVwContractMaintnceService.GetById(Convert.ToInt32(contractid));
            }

            

                return View(dataContract);
            }



            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Save(TbMaintenanceServicesItem contract)
            {
               /*if (!ModelState.IsValid)
                {
                    return View("Edit", contract);
                }*/
                oClsTbMaintenanceServicesItem.save(contract);


                return RedirectToAction("List");
            }

            public IActionResult Delete(int contractid)//this id come from button on html
            {
            oClsTbMaintenanceServicesItem.Delete(contractid);


                return RedirectToAction("List");
            }

        }
    }
