using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TP4_ASP.NET.Data;

namespace TP4_ASP.NET.Controllers
{
    public class UniversityController : Controller
    {
        private StudentRepository repository = new StudentRepository();

        public ViewResult Courses()
        {
           
        return View(repository.GetAllCourses());
        }
      
        public ViewResult StudentsByCourse(string course)
        {
            ViewData["course"] = course;
            return View(repository.GetStudentsByCourse(course));
        }
    }
}
