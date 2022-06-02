using Microsoft.AspNetCore.Mvc;

namespace _222.Controllers
{
    public class EastereggController : Controller
    {
        public IActionResult design() => View();
       
        public IActionResult programming() => View();
    
            
    }
}
