using csharp_boolflix.Data;
using csharp_boolflix.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace csharp_boolflix.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private object _context;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id)
        {
            using (BoolflixContext context = new BoolflixContext())
            {
               
                
                    id = new Random().Next(7, 12);
                    VideoContent filmFound = context.VideoContents.Where(film => film.Id == id).FirstOrDefault();

                    if (filmFound == null)
                    {
                        return NotFound($"La film con id {id} non è stato trovato");
                    }
                    else
                    {
                        return View("Index", filmFound);
                    }
               

                //IQueryable<VideoContent> films = context.VideoContents;
                //return View("Index",films.ToList());
            }
            
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}