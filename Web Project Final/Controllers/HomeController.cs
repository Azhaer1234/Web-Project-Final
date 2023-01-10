using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web_Project_Final.Models;

namespace Web_Project_Final.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly SocialDBContext _context;
        public HomeController(SocialDBContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
