using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MVC.Models.ModelViews.Client
{
    public class ClientDetails
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
    }
}
