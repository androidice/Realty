using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Realty.Areas.Admin.Models;
using Realty.Services.Interfaces;
using Realty.Constants;

namespace Realty.Areas.Admin.Controllers
{
    [Area(AppAreas.Admin)]
    [Authorize]
    public class BusinessManagementController : Controller
    {
        private readonly IBusinessManagementService businessManagementService;

        public BusinessManagementController(IBusinessManagementService businessManagementService)
        {
            this.businessManagementService = businessManagementService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BusinessRegistration() {
            BusinessInfoFormModel model = new BusinessInfoFormModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SaveRegistration(BusinessInfoFormModel model) {

            if (ModelState.IsValid)
            {
                return Redirect(nameof(Index));
            }
            return View(nameof(BusinessRegistration), model);
           
        }
    }
}