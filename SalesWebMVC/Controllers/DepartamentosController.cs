using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();

            list.Add(new Departamento { Id = 1, Nome = "Eletronicos" } ); 
            list.Add(new Departamento { Id = 2, Nome = "Roupas" } );
            list.Add(new Departamento { Id = 3, Nome = "Calçados" });

            return View(list);
        }
    }
}
