using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoAsp.Models;

namespace ProjetoAsp.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { id = 1, name = "Eletroniucs" });
            list.Add(new Department { id = 2, name = "Fashion" });
            return View(list);
        }
    }
}