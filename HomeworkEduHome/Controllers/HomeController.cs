using HomeworkEduHome.DAL;
using HomeworkEduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkEduHome.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _appDbContext;
        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            HomeVM homeVm = new HomeVM();
            homeVm.Sliders = _appDbContext.Sliders.ToList();
            homeVm.Notices = _appDbContext.Notices.ToList();
            homeVm.Teachers = _appDbContext.Teachers.ToList();
            homeVm.Chooses = _appDbContext.Chooses.ToList();
            homeVm.Courses = _appDbContext.Courses.ToList();
            return View(homeVm);
        }
    }
}
