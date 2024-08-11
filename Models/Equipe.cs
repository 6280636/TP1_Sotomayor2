namespace TP1_Sotomayor.Models
{
    public class Equipe
    {
        public int Id { get; set; }
        public string Nom { get; set; }        
        public string ImgFile { get; set; }        
        public string Logo { get; set; }
        public string Description { get; set; }

        //Propriete de Navigation

        public List<Joueur> Joueurs { get; set; }

        public Equipe()
        {
            Joueurs = new List<Joueur>();
        }
    }
}
