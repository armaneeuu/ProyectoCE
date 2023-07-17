using Microsoft.AspNetCore.Mvc;
using ProyectoCalzadosEstrella.Models;

namespace ProyectoCalzadosEstrella.Controllers
{
    public class ContactoController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}