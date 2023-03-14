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

        [DisplayName("Nom du logement")]
        public string nom { get; set; }

        [DisplayName("Prix par personne par nuit (euro)")]
        public decimal prixNuitPersonne { get; set; }

        [DisplayName("Capacité")]
        public int capacite { get; set; }

        [DisplayName("Courte description du logement")]
        public string descriptionCourte { get; set; }

        [DisplayName("Catégorie")]
        public string categorie { get; set; }

        [DisplayName("Proprietaire")]
        public string proprietaire { get; set; }

        [ScaffoldColumn(false)]
        public int idProprietaire { get; set; }

        [ScaffoldColumn(false)]
        public int idCategorie { get; set; }



    }
}
