using EcoTravel_MVC.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MVC.Models.ModelViews.Categorie
{
    public class CategorieDetails
    {
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Identifiant: ")]
        public int idCategorie { get; set; }
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Nom de la categorie: ")]
        public string nom { get; set; }
    }
}
