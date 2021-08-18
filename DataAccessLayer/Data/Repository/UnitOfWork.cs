using DataAccessLayer.Data.Repository.IRepository;
using MyGym.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public ICustomerRepository Customer { get; set; }
        public IApplicationUserRepository ApplicationUser{ get; set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Customer = new CustomerRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
