using app_superboyweb.Data;
using app_superboyweb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;


namespace app_superboyweb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Home/Index
        [HttpGet]
        public IActionResult Index()
        {
            var identity = new Identity(); // Or fetch a single identity from your database
            return View(identity);
        }

        // POST: Home/Index
        [HttpPost]
        public IActionResult Create(Identity model)
        {
            if (ModelState.IsValid)
            {
                _context.Identities.Add(model); // Agregar nuevo registro
                _context.SaveChanges();         // Guardar en la base de datos
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
