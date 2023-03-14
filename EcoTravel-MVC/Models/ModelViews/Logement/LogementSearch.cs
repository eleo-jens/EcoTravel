using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MVC.Models.ModelViews.Logement
{
    public class LogementSearch
    {
        [ScaffoldColumn(false)]
        public int idCategorie { get; set; }
        public IEnumerable<LogementListItems> logements { get; set; }
    }
}
