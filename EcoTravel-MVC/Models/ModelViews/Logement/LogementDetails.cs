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

        [DisplayName("Nom du logement: ")]
        public string nom { get; set; }
        [DisplayName("Courte description du logement: ")]

        public string descriptionCourte { get; set; }
        [DisplayName("Longue description du logement: ")]
        public string descriptionLongue { get; set; }
        [DisplayName("Nombre de chambre: ")]
        public int nbChambres { get; set; }
        [DisplayName("Nombre de salle de bain: ")]
        public int nbPieces { get; set; }
        [DisplayName("Nombre de salle de bain: ")]
        public int nbSDB { get; set; }
        [DisplayName("Nombre de WC: ")]
        public int nbWC { get; set; }
        [DisplayName("Balcon: ")]
        public bool balcon { get; set; } 
        [DisplayName("Air conditionnée: ")]
        public bool airco { get; set; } 
        [DisplayName("Wifi: ")]
        public bool wifi { get; set; } 
        [DisplayName("Minibar: ")]
        public bool minibar { get; set; }
        [DisplayName("Animaus admis: ")]
        public bool animauxAdmis { get; set; } 
        [DisplayName("Piscine: ")]
        public bool piscine { get; set; } 
        [DisplayName("Parking: ")]
        public bool parking { get; set; }
        [DisplayName("Voiturier: ")]
        public bool voiturier { get; set; }
        [DisplayName("Room Service: ")]
        public bool roomService { get; set; } 
        [DisplayName("Spa: ")]
        public bool spa { get; set; } 
        [DisplayName("Prix par nuit par personne (euros): ")]

        public decimal prixNuitPersonne { get; set; }
        [DisplayName("Capacité (nombre de personnes): ")]
        public int capacite { get; set; }
        [DisplayName("Longitude: ")]
        public decimal longitude { get; set; }
        [DisplayName("Latitude: ")]
        public decimal latitude { get; set; }
        [DisplayName("Rue: ")]
        public string rue { get; set; }
        [DisplayName("Numéro: ")]
        public string numero { get; set; }
        [DisplayName("Code postal: ")]
        public string codePostal { get; set; }
        [DisplayName("Pays: ")]
        public string pays { get; set; }

        // Ici je dois afficher le nom de la catégorie
        // et le nom du proprietaire
        [DisplayName("Categorie: ")]
        public string categorie { get; set; }
        [DisplayName("Proprietaire: ")]
        public string nomProprietaire { get; set; }

        [ScaffoldColumn(false)]
        public int idCategorie { get; set; }
        [ScaffoldColumn(false)]
        public int idProprietaire { get; set; }
    }
}
