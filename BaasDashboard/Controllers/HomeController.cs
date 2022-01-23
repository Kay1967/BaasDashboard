using BaasDashboard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BaasDashboard.Data;


namespace BaasDashboard.Controllers
{
    public class HomeController : Controller
    { 
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        //public HomeController(ILogger<HomeController> logger)
       // {
           // _logger = logger;
        //}    
        public HomeController(ApplicationDbContext context)
        {

            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Index(Login login)
        {
            var account = _context.Accounts.FirstOrDefault(n => n.Email == login.Email);
            if (account == null)
            {
                return BadRequest();
            }
            if(account.Password == login.Password)
            {
                return RedirectToAction("Index", "Users", account.Id);
            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}