using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManager.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManager.Mvc.Controllers
{
    public class EmployeeManagerController : Controller
    {
        private AppDbContext db = null;
        public EmployeeManagerController(AppDbContext db)
        {
            this.db = db;
        }

        private void FillCountries()
        {
            List<SelectListItem> countries =
            (from c in db.Countries
             orderby c.Name ascending
             select new SelectListItem()
             {
                 Text = c.Name,
                 Value = c.Name
             }).ToList();
            ViewBag.Countries = countries;
        }
    }
}
