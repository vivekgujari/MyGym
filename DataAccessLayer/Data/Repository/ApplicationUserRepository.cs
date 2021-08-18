using DataAccessLayer.Data.Repository.IRepository;
using Models;
using MyGym.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Data.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
