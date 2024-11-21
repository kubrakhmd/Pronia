using Microsoft.AspNetCore.Mvc;
using Pronia.DAL;
using Pronia.Models;
using Pronia.ViewModels;

namespace Pronia.Controllers
{
    public class HomeController:Controller
    {
        public readonly ProniaDBContext _context;

        public HomeController(ProniaDBContext context)
        {
            _context =context;
            
        }
        public IActionResult Index()
        {


           
            //_context.Slides.AddRange(slides);
            //_context.SaveChanges();
            HomeVM homeVM = new HomeVM
            {
                Slides = _context.Slides.OrderBy(s=>s.Order).Take(2).ToList()
            };

            return View(homeVM);
        }

    }
}
