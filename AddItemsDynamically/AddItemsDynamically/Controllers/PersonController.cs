using AddItemsDynamically.Data;
using AddItemsDynamically.Models;
using Microsoft.AspNetCore.Mvc;


namespace AddItemsDynamically.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(Person person)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ViewData["Name"] = person.Name;
                    ViewData["City"] = person.City;
                    ViewData["Address"] = person.Address;
                    
                    return View("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

    }
}