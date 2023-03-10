using EcoTravel_BLL.Entities;
using EcoTravel_MVC.Handlers;
using EcoTravel_MVC.Models.ModelViews.Categorie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MVC.Models.ModelViews.Logement
{
    public class LogementCreateForm
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
        public string descriptionCourte { get; set; }
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Longue description du logement: *")]
        [MinLength(2)]
        public string descriptionLongue { get; set; }
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Nombre de chambre (il en faut minimum 1!): *")]
        [Range(1, 100, ErrorMessage = "Entre 1 et 100 chambres")]
        public int nbChambres { get; set; }
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Nombre de salle de bain (il en faut minimum 3!): *")]
        [Range(3, 100, ErrorMessage = "Entre 3 et 255 pièces")]
        public int nbPieces { get; set; }
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Nombre de salle de bain (il en faut minimum 1!): *")]
        [Range(1, 100, ErrorMessage = "Entre 1 et 100 salles de bain")]
        public int nbSDB { get; set; }
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Nombre de WC (il en faut minimum 1!): *")]
        [Range(1, 100, ErrorMessage = "Entre 1 et 100 toilettes")]
        public int nbWC { get; set; }
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Balcon: *")]
        public bool balcon { get; set; } = true;
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Air conditionnée: *")]
        public bool airco { get; set; } = true;
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Wifi: *")]
        public bool wifi { get; set; } = true;
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Minibar: *")]
        public bool minibar { get; set; } = true;
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Animaus admis: *")]
        public bool animauxAdmis { get; set; } = true;
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Piscine: *")]
        public bool piscine { get; set; } = true;
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Parking: *")]
        public bool parking { get; set; } = true;
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Voiturier: *")]
        public bool voiturier { get; set; } = true;
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Room Service: *")]
        public bool roomService { get; set; } = true;
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Spa: *")]
        public bool spa { get; set; } = true;
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Prix par nuit par personne (euros): *")]

        public decimal prixNuitPersonne { get; set; }
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Capacité (nombre de personnes): *")]
        [Range(1, 255, ErrorMessage = "Entre 1 et 255 personnes")]
        public int capacite { get; set; }
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Longitude: *")]
        [Range(-180, 180, ErrorMessage = "Entre -180 et 180")]
        public decimal longitude { get; set; }
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Latitude: *")]
        [Range(-90, 90, ErrorMessage = "Entre -90 et 90")]
        public decimal latitude { get; set; }
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Rue: *")]
        [MinLength(1)]
        [MaxLength(255)]
        public string rue { get; set; }
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Numéro: *")]
        [MinLength(1)]
        [MaxLength(10)]
        public string numero { get; set; }
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Code postal: *")]
        [MinLength(4)]
        [MaxLength(10)]
        public string codePostal { get; set; }
        [Required(ErrorMessage = ConstantMessages.errorMessage)]
        [DisplayName("Pays: *")]
        [MinLength(1)]
        [MaxLength(2)]
        public string pays { get; set; }

        // Ici je dois récupérer la liste des categories
        [ScaffoldColumn(false)]
        public int idCategorie { get; set; }
        [ScaffoldColumn(false)]
        public int idProprietaire { get; set; }
    }
}
