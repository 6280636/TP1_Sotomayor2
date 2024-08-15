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

        //Get Create
        public IActionResult Create()
        {

            return View();
        }

        //Post
        [HttpPost]
        public IActionResult Create(Models.Equipe equipe)
        {
            if (ModelState.IsValid)
            {
                _baseDonnees.Equipe.Add(equipe);
                _baseDonnees.SaveChanges();
                TempData["Succes"] = $"{equipe.Nom} equipe added";
                return RedirectToAction("Index");
            }
            return View(equipe);
        }
    }
}

