using Microsoft.AspNetCore.Mvc;
using ProyectoCalzadosEstrella.Models;
using ProyectoCalzadosEstrella.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ProyectoCalzadosEstrella.Controllers
{
    public class CatalogoController:Controller
    {
        private readonly ApplicationDbContext _context;

        public CatalogoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var productos = from o in _context.DataProducts select o;
            return View(await productos.ToListAsync());
        }
    }
}