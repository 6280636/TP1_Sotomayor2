using Microsoft.AspNetCore.Mvc;
using TP1_Sotomayor.Models;
using TP1_Sotomayor.Models.Data;

namespace TP1_Sotomayor.Controllers
{
    public class HomeController : Controller
    {
        private TP1DbContext _baseDonnees { get; set; }
        public HomeController(TP1DbContext baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }

        public IActionResult Index()
        {
            List<Equipe> equipes = _baseDonnees.Equipe.ToList();
            return View(equipes);
        }
    }
}

