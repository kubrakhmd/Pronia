using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


           //Product product = _context.Products.Include(p=>p.Category).FirstOrDefault();
            //_context.Slides.AddRange(slides);
            //_context.SaveChanges();
            HomeVM homeVM = new HomeVM
            {
                Slides = _context.Slides.OrderBy(s=>s.Order).Take(2).ToList(),
                Products=_context.Products.Include(p=>p.ProductImages).ToList(),
            };

            return View(homeVM);
        }

    }
}
