using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _222.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        public IActionResult Log_in()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
    }
}
