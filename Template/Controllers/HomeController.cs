using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Template.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Template.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            Product product = new Product();
            product.Id = 1;
            product.Name = "Test";
            return View(product);
        }

        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Test2()
        {

            return View();
        }
        public IActionResult FirstForm()
        {

            return View();
        }
        [HttpPost]
        public IActionResult FirstForm(EnteringInformation model)
        {
          
            return ResultForm();
        }
        public IActionResult ResultForm()
        {

            return View();
        }

        public IActionResult SecondForm()
        {

            return View();
        }
        [HttpPost]
        public IActionResult SecondForm(EnteringInformation model)
        {
           
            List<ResultSelect> choises = new List<ResultSelect>();

            choises.Add(new ResultSelect()
            {
                QuantityDreams = 2
            });
            choises.Add(new ResultSelect()
            {
                QuantityDreams = 1
            });

            return View("Selection", choises);
        }
        
    }
}

