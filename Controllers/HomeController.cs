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
            List<Equipe> equipes = _baseDonnees.Equipe
                //.OrderBy(e => e.Nom)
                .ToList();
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
        public IActionResult Edit(int id)
        {
            Equipe equipe = _baseDonnees.Equipe.Find(id);

            return View(equipe);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Equipe equipe)
        {
            if (ModelState.IsValid)
            {
                _baseDonnees.Equipe.Update(equipe);
                _baseDonnees.SaveChanges();
                TempData["Success"] = $"Equipe {equipe.Nom} has been modified";
                return this.RedirectToAction("Index");
            }

            return View(equipe);
        }
    }
}

