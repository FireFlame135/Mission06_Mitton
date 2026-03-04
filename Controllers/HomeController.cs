using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Mitton.Models;

namespace Mission06_Mitton.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;

        // Constructor to bring in the database context
        public HomeController(MovieContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Joel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie response)
        {
            // If the required fields are filled out correctly
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); // Add record to the database
                _context.SaveChanges();        // Save the changes

                return View("Confirmation", response);
            }

            // If data is invalid, reload the form so they can fix it
            return View(response);
        }
    }
}