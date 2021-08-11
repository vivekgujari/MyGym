using DataAccessLayer.Data.Repository.IRepository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using MyGym.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        protected readonly ApplicationDbContext _db;

        public CustomerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetCustomerListForDropDown()
        {
            throw new NotImplementedException();
        }
 
        public void Update(Customer Customer)
        {
            
        }
    }
}
