using System.ComponentModel.DataAnnotations;

namespace TP1_Sotomayor.Models
{
    public class Joueur
    {
        //private string ImgFile = "mesipet.png";

        public int Id { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }            
        public string Equipe { get; set; }
        public int Buts { get; set; }       
        public string ImgFile { get; set; }

        // Propriete de Navigation

        public int ParentId { get; set; }
        public Equipe Parent { get; set; }


    }
}
