using Realty.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Realty.Services.Interfaces
{
    public interface IBusinessManagementService
    {
        Task<string> RegisterBusiness(BusinessInfoServiceModel info);
    }
}
