using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Realty.Data;
using Realty.Services.Interfaces;
using Realty.Services.Models;

namespace Realty.Services
{
    public class BusinessManagementService: IBusinessManagementService
    {
        private readonly ApplicationDbContext context;

        public BusinessManagementService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<string> RegisterBusiness(BusinessInfoServiceModel info) {


            this.context.BusinessInfo.Add(new BusinessInfo() { });
            return string.Empty;
        }
    }
}
