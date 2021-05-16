using Microsoft.AspNetCore.Mvc;
using SallesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronico" });
            list.Add(new Department { Id = 2, Name = "Fashion" });


            return View(list);
        }
    }
}
