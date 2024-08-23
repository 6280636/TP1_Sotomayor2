using TP1_Sotomayor.Models;


namespace TP1_Sotomayor.Views.ViewModels
{
    public class PageRechercheViewModel
    {
        public CritereRechercheViewModel Criteres { get; set; }
        public List<Joueur> Resultat { get; set; }

    }
}
