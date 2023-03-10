using EcoTravel_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_DAL.Entities
{
    // A Faire: changer le nom de l'entité Type en Catégories car être confondu avec System.Type ! 
    public class Categorie: ICategorie
    {
        public int idCategorie { get; set; }
        public string nom { get; set; }
    }
}
