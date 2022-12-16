using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TP4_ASP.NET.Models;
using TP4_ASP.NET.Models.Data;

namespace TP4_ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            UniversityContext context = UniversityContext.Context;
            List<Student> students = context.Student.ToList();
            foreach (Student s in students)
            {
                Debug.WriteLine(s.Id + " " + s.First_Name + " " + s.Last_Name + " " + s.University + " " + s.Phone_Number, " ", s.Timestamp);
            }
            Debug.WriteLine(context);
            return View();
        }

        public IActionResult Privacy()
        {
            UniversityContext context = UniversityContext.Context;
            Debug.WriteLine(context);
            return View();
        }

    }
}
