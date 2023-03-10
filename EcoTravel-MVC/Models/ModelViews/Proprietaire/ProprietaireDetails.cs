using EcoTravel_MVC.Models.ModelViews.Logement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MVC.Models.ModelViews.Proprietaire
{
    public class ProprietaireDetails
    {
        [DisplayName("Identifiant: ")]
        public int idClient { get; set; }
        [DisplayName("Nom de famille: ")]
        public string nom { get; set; }
        [DisplayName("Prénom: ")]
        public string prenom { get; set; }
        [DisplayName("Email: ")]
        public string pays { get; set; }
        [DisplayName("Pays: ")]
        public string email { get; set; }
        [DisplayName("Numéro de téléphone: ")]
        public string telephone { get; set; }
        [DisplayName("Vos logements")]
        public IEnumerable<LogementListItems> logements { get; set; }
    }
}
