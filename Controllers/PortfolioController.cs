using homeworkASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeworkASP.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;
        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Portfolio> portfolios = _context.Portfolios.ToList();
            
            return View(portfolios);
        }
        public IActionResult Detail(int id)
        {
            Portfolio port = _context.Portfolios.Include(p=>p.PortfolioImages).FirstOrDefault(p => p.Id == id);
            if (port == null) return NotFound();

            return View(port);
        }
    }
}
