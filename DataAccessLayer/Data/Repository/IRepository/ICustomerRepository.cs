using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;

namespace DataAccessLayer.Data.Repository.IRepository
{
    public interface ICustomerRepository : IRepository<Customer> 
    {
        IEnumerable<SelectListItem> GetCustomerListForDropDown();
        void Update(Customer Customer);
    }
}
