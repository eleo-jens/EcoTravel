using EcoTravel_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_BLL.Entities
{
    public class Categorie: ICategorie
    {
        public int idCategorie { get; set; }
        public string nom { get; set; }
    }
}
