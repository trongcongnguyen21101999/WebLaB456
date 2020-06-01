using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLab456.Models;
using WebLab456.ViewModels;

namespace WebLab456.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        [Authorize]
        [HttpPost]
        public ActionResult Create()
        {
            var ViewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(ViewModel);
        }
    }
}