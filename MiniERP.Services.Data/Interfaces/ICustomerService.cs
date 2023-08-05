using MiniERP.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Services.Data.Interfaces
{
    public interface ICustomerService
    {
        Task<ICollection<CustomerViewModel>> GetAll();
        Task<CustomerViewModel> GetById(int id);
        Task<bool> Create(CustomerViewModel input);
        Task<bool> Edit(CustomerViewModel input);
        Task<bool> Delete(int id);
        Task<bool> IsExist(int id);
    }
}
