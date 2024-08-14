using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace TP1_Sotomayor.Models
{
    public class Equipe
    {
        [Key]
        public int Id { get; set; }

        [StringLength(15, MinimumLength = 5)]
        public string Nom { get; set; }

        [StringLength(250)]
        public string ImgFile { get; set; }

        [StringLength(250)]
        public string Logo { get; set; }

        [StringLength(3000)]
        public string Description { get; set; }

        //Propriete de Navigation
        [ValidateNever]
        public ICollection<Joueur> Joueurs { get; set; }

        //public Equipe()
        //{
        //    Joueurs = new List<Joueur>();
        //}
    }
}
