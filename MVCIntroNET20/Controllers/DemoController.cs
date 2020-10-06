using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCIntroNET20.Models;

namespace MVCIntroNET20.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index(string name, int salary)
        {
            //ViewData["name"] = name;
            //ViewData["salary"] = salary;
             
            //ViewData["id"] = id;
            //ViewBag.Id = id;
            //ViewBag.Banan = "Banan";

            var model = new Employee
            {
                Name = name,
                Salary = salary
            };

            return View(model);
        }
    }
}
