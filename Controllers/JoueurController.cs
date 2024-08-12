using Microsoft.AspNetCore.Mvc;
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
            IEnumerable<Joueur> donnees = _baseDonnees.Joueurs;

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
    }
}
