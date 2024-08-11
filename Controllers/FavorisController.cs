using Microsoft.AspNetCore.Mvc;
using TP1_Sotomayor.Models;
using TP1_Sotomayor.Views.ViewModels;

namespace TP1_Sotomayor.Controllers
{
    public class FavorisController : Controller
    {
        private BaseDeDonnees DB { get; set; }
        public FavorisController(BaseDeDonnees db)
        {
            this.DB = db;
        }
        public IActionResult Index()
        {
            var JoueurId = HttpContext.Session.Get<List<int>>("JoueurId");
            if(JoueurId == null)
            {
                JoueurId= new List<int>();
            }
            var JoueurDeLaBD = this.DB.Joueurs.Where(e => JoueurId.Contains(e.Id)).ToList();
            return View(JoueurDeLaBD);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AjouterUnJoueur(int id)
        {
            List<int> Joueurs = HttpContext.Session.Get<List<int>>("JoueurId"); 
            if (Joueurs == null)
            {
                Joueurs = new List<int>();
            }
            
            Joueurs.Add(id);
            HttpContext.Session.Set<List<int>>("JoueurId", Joueurs);
            return RedirectToAction("Index");

        }
        public IActionResult SupprimerUnJoueur(int id)
        {
            List<int> Joueurs = HttpContext.Session.Get<List<int>>("JoueurId");
            if (Joueurs == null)
            {
                Joueurs = new List<int>();
            }

            Joueurs.Remove(id);
            HttpContext.Session.Set<List<int>>("JoueurId", Joueurs);
            return RedirectToAction("Index");
        }
    }
}
