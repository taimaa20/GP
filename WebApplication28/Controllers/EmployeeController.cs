using Microsoft.AspNetCore.Mvc;
using WebApplication28.Models;

namespace WebApplication28.Controllers
{
    public class EmployeeController : Controller

    {
        private readonly HomeServicesNewContext _context;
        public EmployeeController(HomeServicesNewContext context) 
        { 
            
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
