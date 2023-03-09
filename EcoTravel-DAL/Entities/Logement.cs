using EcoTravel_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_DAL.Entities
{
    public class Logement: ILogement
    {
        public int idLogement { get; set; }
        public string nom { get; set; }
        //nvarchar(255)
        public string descriptionCourte { get; set; }
        //nvarchar(max)
        public string descriptionLongue { get; set; }

        public int nbChambres { get; set; }
        public int nbPieces { get; set; }
        public int nbSDB { get; set; }
        public int nbWC { get; set; }
        public bool balcon { get; set; }
        public bool airco { get; set; }
        public bool wifi { get; set; }
        public bool minibar { get; set; }
        public bool animauxAdmis { get; set; }
        public bool piscine { get; set; }
        public bool parking { get; set; }
        public bool voiturier { get; set; }
        public bool roomService { get; set; }
        public bool spa { get; set; }
        public decimal prixNuitPersonne { get; set; }
        public int capacite { get; set; }
        //DECIMAL(9,6)
        public decimal longitude { get; set; }
        //DECIMAL(8,6)
        public decimal latitude { get; set; }
        //nvarchar(255)
        public string rue { get; set; }
        //nvarchar(10)
        public string numero { get; set; }
        //nvarchar(10)
        public string codePostal { get; set; }
        //char(2)
        public string pays { get; set; }
        // DATE
        public DateTime dateAjout { get; set; }
    }
}
