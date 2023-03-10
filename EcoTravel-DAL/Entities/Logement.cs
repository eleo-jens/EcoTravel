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
        //tinyint
        public int nbChambres { get; set; }
        //tinyint
        public int nbPieces { get; set; }
        //tinyint
        public int nbSDB { get; set; }
        //tinyint
        public int nbWC { get; set; }
        //bit
        public bool balcon { get; set; }
        //bit
        public bool airco { get; set; }
        //bit
        public bool wifi { get; set; }
        //bit
        public bool minibar { get; set; }
        //bit
        public bool animauxAdmis { get; set; }
        //bit
        public bool piscine { get; set; }
        //bit
        public bool parking { get; set; }
        //bit
        public bool voiturier { get; set; }
        //bit
        public bool roomService { get; set; }
        //bit
        public bool spa { get; set; }
        //money
        public decimal prixNuitPersonne { get; set; }
        //tinyint
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
        public int idCategorie{ get; set; }
        public int idProprietaire { get; set; }
    }
}
