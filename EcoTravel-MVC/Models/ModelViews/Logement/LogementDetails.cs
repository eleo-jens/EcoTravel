using EcoTravel_MVC.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MVC.Models.ModelViews.Logement
{
    public class LogementDetails
    {
        [ScaffoldColumn(false)]
        public int idLogement { get; set; }

        
        [DisplayName("Nom du logement: *")]
        public string nom { get; set; }
        [DisplayName("Courte description du logement (max 255 caractères: *")]

        public string descriptionCourte { get; set; }
        [DisplayName("Longue description du logement: *")]
        public string descriptionLongue { get; set; }
        [DisplayName("Nombre de chambre (il en faut minimum 1!): *")]
        public int nbChambres { get; set; }
        [DisplayName("Nombre de salle de bain (il en faut minimum 3!): *")]
        public int nbPieces { get; set; }
        [DisplayName("Nombre de salle de bain (il en faut minimum 1!): *")]
        public int nbSDB { get; set; }
        [DisplayName("Nombre de WC (il en faut minimum 1!): *")]
        public int nbWC { get; set; }
        [DisplayName("Balcon: *")]
        public bool balcon { get; set; } = true;
        [DisplayName("Air conditionnée: *")]
        public bool airco { get; set; } = true;
        [DisplayName("Wifi: *")]
        public bool wifi { get; set; } = true;
        [DisplayName("Minibar: *")]
        public bool minibar { get; set; } = true;
        [DisplayName("Animaus admis: *")]
        public bool animauxAdmis { get; set; } = true;
        [DisplayName("Piscine: *")]
        public bool piscine { get; set; } = true;
        [DisplayName("Parking: *")]
        public bool parking { get; set; } = true;
        [DisplayName("Voiturier: *")]
        public bool voiturier { get; set; } = true;
        [DisplayName("Room Service: *")]
        public bool roomService { get; set; } = true;
        [DisplayName("Spa: *")]
        public bool spa { get; set; } = true;
        [DisplayName("Prix par nuit par personne (euros): *")]

        public decimal prixNuitPersonne { get; set; }
        [DisplayName("Capacité (nombre de personnes): *")]
        public int capacite { get; set; }
        [DisplayName("Longitude: *")]
        public decimal longitude { get; set; }
        [DisplayName("Latitude: *")]
        public decimal latitude { get; set; }
        [DisplayName("Rue: *")]
        public string rue { get; set; }
        [DisplayName("Numéro: *")]
        public string numero { get; set; }
        [DisplayName("Code postal: *")]
        public string codePostal { get; set; }
        [DisplayName("Pays: *")]
        public string pays { get; set; }

        // Ici je dois récupérer la liste des categories
        [ScaffoldColumn(false)]
        public int idCategorie { get; set; }
        [ScaffoldColumn(false)]
        public int idProprietaire { get; set; }
    }
}
