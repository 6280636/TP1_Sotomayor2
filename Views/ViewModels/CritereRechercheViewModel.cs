namespace TP1_Sotomayor.Views.ViewModels
{
    public class CritereRechercheViewModel
    {
        public string NomDuJueur { get; set; }
        public bool EstJoueurDuBarselona { get; set; }
        public bool EstJoueurDuRealMadrid { get; set; }
        public bool EstJoueurDuAtleticoMadrid { get; set; }
        public int? MaxNbrDeButs { get; set; }
        public int? MinNbrDeButs { get; set; }
        public string StatusDuJueur { get; set; }
       
    }
}
