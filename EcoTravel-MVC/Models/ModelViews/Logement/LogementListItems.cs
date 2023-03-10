using EcoTravel_MVC.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MVC.Models.ModelViews.Logement
{
    public class LogementListItems
    {
        [ScaffoldColumn(false)]
        public int idLogement { get; set; }

        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Nom du logement: *")]
        [MinLength(2)]
        [MaxLength(50)]
        public string nom { get; set; }

        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Courte description du logement (max 255 caractères: *")]
        [MinLength(2)]
        [MaxLength(255)]
        public decimal prixNuitPersonne { get; set; }

        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Capacité (nombre de personnes): *")]
        [Range(1, 255, ErrorMessage = "Entre 1 et 255 personnes")]
        public int capacite { get; set; }

        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Courte description du logement (max 255 caractères: *")]
        [MinLength(2)]
        [MaxLength(255)]
        public string descriptionCourte { get; set; }

    }
}
