using Microsoft.AspNetCore.Mvc;
using WebApplication28.Models;

namespace WebApplication28.Controllers
{
    public class AdminController : Controller
    {
        private readonly HomeServicesNewContext _context;

        public AdminController(HomeServicesNewContext context)
        {
            _context = context;
        }
        HomeServicesNewContext db = new HomeServicesNewContext();
        public IActionResult AllUsers()
        {
            //FetchData();

            
            List<User> user = db.Users.ToList();
           


            return View(user.ToList());


        }
        public IActionResult services()
        {
            //FetchData();


            List<Service> services = db.Services.ToList();



            return View(services.ToList());


        }
        public IActionResult Index()

        {


            ViewBag.countOFEmployees = _context.Logins.Where(x => x.RoleId == 2).Count();
            ViewBag.countOFUsers = _context.Users.Count();
            return View();
        }
    }
}
