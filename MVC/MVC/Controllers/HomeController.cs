using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace MVC.Controllers
{
        public class HomeController : Controller
        {
            private readonly ApplicationDbContext _context;

            public HomeController(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<IActionResult> Index()
            {
                var users = await _context.Users.ToListAsync();
                return View(users);
            }
        }
}
