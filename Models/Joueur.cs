using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP1_Sotomayor.Models
{
    public class Joueur
    {
        //private string ImgFile = "mesipet.png";
        [Key]
        public int Id { get; set; }

        [StringLength(15, MinimumLength = 5)]
        public string Nom { get; set; }
        public int Age { get; set; }

        [StringLength(250)]
        public string Description { get; set; }
        //public string Equipe { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Les buts doit être un nombre positif.")]
        public int Buts { get; set; }

        [StringLength(250)]
        public string ImgFile { get; set; }

        // Propriete de Navigation
        [Display(Name = "Equipe")]
        [ForeignKey("Equipe")]
        public int EquipeId { get; set; }

        [ValidateNever]
        public Equipe Equipe { get; set; }


    }
}
