using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLab456.Models;

namespace WebLab456.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}