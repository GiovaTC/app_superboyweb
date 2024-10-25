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

/*        // GET: Home/Index
        [HttpGet]
        public IActionResult Index()
        {
            // Recupera el primer registro de la tabla "Identities"
            var identity = _context.Identities.FirstOrDefault(i => i.Id == 1);

            // Si no se encuentra el registro, devolver uno vacío o manejar el error
            if (identity == null)
            {
                identity = new Identity { Id = 0, Nombre = "No encontrado", Correo = "n/a" };
            }

            // Pasar el objeto identity a la vista
            return View(identity);
        }
*/
        // GET: Home/Index
        [HttpGet]
        public IActionResult Index() //listar
        {
            // Intenta recuperar todos los registros, si la tabla puede estar vacía
            var identities = _context.Identities.ToList();

            // Si no hay registros en la base de datos, crea una colección temporal con un solo registro vacío
            if (!identities.Any())
            {
                identities = new List<Identity>
        {
            new Identity { Id = 0, Nombre = "No encontrado", Correo = "n/a" }
        };
            }

            // Pasar la lista a la vista, asegurando que siempre sea una colección
            return View(identities);
        }

        // POST: Home/Index 
        [HttpPost]
        public IActionResult Create(Identity model)
        {
            if (ModelState.IsValid)
            {
                _context.Identities.Add(model); // Agregar nuevo registro
                _context.SaveChanges();         // Guardar en la base de datos
                return RedirectToAction("Index"); // Redirigir a la lista de identidades
            }

            // Si hay un error, regresa a la vista con el modelo
            return View("Index", new List<Identity> { model }); // Pasar una colección con el nuevo objeto
        }
    }
}
