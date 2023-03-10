using EcoTravel_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_BLL.Entities
{
    public class Logement : ILogement
    {
        public int idLogement { get; set; }
        public string nom { get; set; }
        public string descriptionCourte { get; set; }
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
        public decimal longitude { get; set; }
        public decimal latitude { get; set; }
        public string rue { get; set; }
        public string numero { get; set; }
        public string codePostal { get; set; }
        public string pays { get; set; }
        public DateTime dateAjout { get; set; }
        public int idCategorie { get; set; }
        public int idProprietaire { get; set; }
    }
}
