using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseWorkPIS.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CourseWorkPIS.Controllers
{
    public class AdminController : Controller
    {
        UserManager<IdentityUser> _userManager;
        public AdminController(UserManager<IdentityUser> manager)
        {
            _userManager = manager;
        }
        public IActionResult Index()
        {
            return View(_userManager.Users.ToList());
        }
    }
}