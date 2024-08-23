using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP1_Sotomayor.Models;
using TP1_Sotomayor.Models.Data;
using TP1_Sotomayor.Views.ViewModels;


namespace TP1_Sotomayor.Controllers
{
    public class JoueurController : Controller
    {
        private TP1DbContext _baseDonnees { get; set; }
        public JoueurController(TP1DbContext baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }
        public IActionResult Recherche()
        {
            var model = new PageRechercheViewModel();
            model.Criteres = new CritereRechercheViewModel();
            model.Criteres.EstJoueurDuBarselona = true;
            model.Criteres.EstJoueurDuRealMadrid = true;
            model.Criteres.EstJoueurDuAtleticoMadrid = true;
            //model.Criteres.NomDuJueur = "Antoine";

            model.Resultat = _baseDonnees.Joueurs.ToList();

            return View(model);
        }

        [Route("/Joueur/Detail/{id:int}")]
        [Route("/Joueur/{id:int}")]
        [Route("/{id:int}")]
        public IActionResult DetailParID(int id)
        {
            var personneRecherche = _baseDonnees.Joueurs.Where(e=> e.Id == id).SingleOrDefault();
            if (personneRecherche == null)
            {
                ViewData["Message2"] = "Le joueur demandé n'a pas été trouvé!";
                return View("NonTrouve", ViewData["Message2"]);
            }
            
                return View("Detail", personneRecherche);
            
           
        }

        [Route("/Joueur/Detail")]        
        public IActionResult DetailParNom(string id)
        {
            var personneRecherche = _baseDonnees.Joueurs.Where(e => e.Nom.ToUpper() == id).SingleOrDefault();
            if (personneRecherche == null)
            {
                ViewData["Message"] = "Il faut choisir un Jueur";
                return View("NonTrouve", ViewData["Message"]);
            }
           
                return View("Detail", personneRecherche);
                      

        }
        [HttpGet]
        public IActionResult Filter(CritereRechercheViewModel critere)
        {
            IEnumerable<Joueur> donnees = _baseDonnees.Joueurs.Include(j => j.Equipe);

            if (critere.NomDuJueur != null)
            {
                donnees = donnees.Where(c => c.Nom.ToLower() == critere.NomDuJueur.ToLower()
                || c.Equipe.Nom.ToLower() == critere.NomDuJueur.ToLower());
            }           
            if (!critere.EstJoueurDuBarselona)
            {
                donnees = donnees.Where(c => c.Equipe.Nom != "Barcelona");
            }
            if (!critere.EstJoueurDuRealMadrid)
            {
                donnees = donnees.Where(c => c.Equipe.Nom != "Real Madrid");
            }
            if (!critere.EstJoueurDuAtleticoMadrid)
            {
                donnees = donnees.Where(c => c.Equipe.Nom != "Atletico Madrid");
            }
           
            if (critere.MinNbrDeButs != null)
            {
                donnees = donnees.Where(c => c.Buts >= critere.MinNbrDeButs);
            }
            if (critere.MaxNbrDeButs != null)
            {
                donnees = donnees.Where(c => c.Buts >= critere.MaxNbrDeButs);
            }
            var pageRechercheViewModel = new PageRechercheViewModel();
            
            pageRechercheViewModel.Criteres = critere;

            pageRechercheViewModel.Resultat = donnees.ToList();
            if (pageRechercheViewModel.Resultat.Count == 0)
            {
                ViewData["Message"] = "Lo siento, no se encontraron resultados.";
               
            }
            
                return View("Recherche",pageRechercheViewModel);        

        }
        //Get Create
        public IActionResult Create()
        {
            var equipes = _baseDonnees.Equipe.ToList();
            ViewBag.EquipeList = new SelectList(equipes, "Id", "Nom"); // Id es el valor enviado, Nom es el texto mostrado
            return View();
        }

        //Post
        [HttpPost]
        public IActionResult Create(Models.Joueur joueur)
        {
            if (ModelState.IsValid)
            {
                _baseDonnees.Joueurs.Add(joueur);
                _baseDonnees.SaveChanges();
                TempData["Succes"] = $"{joueur.Nom} joueur added";
                return RedirectToAction("Recherche");
            }
            return View(joueur);
        }
        public IActionResult Edit(int id)
        {
            Joueur joueur = _baseDonnees.Joueurs.Find(id);

            return View(joueur);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Joueur joueur)
        {
            if (ModelState.IsValid)
            {
                _baseDonnees.Joueurs.Update(joueur);
                _baseDonnees.SaveChanges();
                TempData["Success"] = $"Joueur {joueur.Nom} has been modified";
                return this.RedirectToAction("Recherche");
            }

            return View(joueur);
        }
        public IActionResult Delete(int id)
        {
            Joueur? joueur = _baseDonnees.Joueurs.Find(id);
            if (joueur == null)
            {
                return NotFound();
            }

            return View(joueur);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id)
        {
            Joueur? joueur = _baseDonnees.Joueurs.Find(id);
            if (joueur == null)
            {
                return NotFound();
            }

            _baseDonnees.Joueurs.Remove(joueur);
            _baseDonnees.SaveChanges();
            TempData["Success"] = $"Joueur {joueur.Nom} has been removed";
            return RedirectToAction("Recherche");
        }
      

        
    }
}
