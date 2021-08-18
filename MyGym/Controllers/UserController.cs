using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Data.Repository;
using DataAccessLayer.Data.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace MyGym.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Json(new { data = _unitOfWork.ApplicationUser.GetAll()});
        }
        
    }
}
