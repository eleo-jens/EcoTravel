using System;
using BO = EcoTravel_BLL.Entities;
using DO = EcoTravel_DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoTravel_BLL.Entities;

namespace EcoTravel_BLL.Mapper
{
    static class Mapper
    {
        #region Client
        public static BO.Client ToBLL(this DO.Client entity)
        {
            if (entity is null) return null;
            return new BO.Client()
            {
                idClient = entity.idClient,
                nom = entity.nom,
                prenom = entity.prenom,
                email = entity.email,
                telephone = entity.telephone,
                pays = entity.pays,
                password = entity.password
            };
        }

        public static DO.Client ToDAL(this BO.Client entity)
        {
            if (entity is null) return null;
            return new DO.Client()
            {
                idClient = entity.idClient,
                nom = entity.nom,
                prenom = entity.prenom,
                email = entity.email,
                telephone = entity.telephone,
                pays = entity.pays,
                password = entity.password
            };
        }
        #endregion

        #region Logement
        public static Logement ToBLL(this DO.Logement entity)
        {
            if (entity is null) return null;
            return new Logement()
            {
                idLogement = entity.idLogement,
                nom = entity.nom,
                descriptionCourte = entity.descriptionCourte,
                descriptionLongue = entity.descriptionLongue,
                nbChambres = entity.nbChambres,
                nbPieces = entity.nbPieces,
                nbSDB = entity.nbSDB,
                nbWC= entity.nbWC,
                balcon = entity.balcon, 
                airco= entity.airco,
                wifi= entity.wifi,
                minibar= entity.minibar,
                animauxAdmis= entity.animauxAdmis,
                piscine= entity.piscine,
                parking= entity.parking,
                voiturier= entity.voiturier,
                roomService= entity.roomService,
                spa = entity.spa,
                prixNuitPersonne= entity.prixNuitPersonne,
                capacite= entity.capacite,
                longitude= entity.longitude,
                latitude= entity.latitude,
                rue= entity.rue,
                numero= entity.numero,
                codePostal= entity.codePostal,
                pays= entity.pays,
                dateAjout= entity.dateAjout,
                idCategorie = entity.idCategorie,
                idProprietaire= entity.idProprietaire
            };
        }

        public static DO.Logement ToDAL(this BO.Logement entity)
        {
            if (entity is null) return null;
            return new DO.Logement()
            {
                idLogement = entity.idLogement,
                nom = entity.nom,
                descriptionCourte = entity.descriptionCourte,
                descriptionLongue = entity.descriptionLongue,
                nbChambres = entity.nbChambres,
                nbPieces = entity.nbPieces,
                nbSDB = entity.nbSDB,
                nbWC = entity.nbWC,
                balcon = entity.balcon,
                airco = entity.airco,
                wifi = entity.wifi,
                minibar = entity.minibar,
                animauxAdmis = entity.animauxAdmis,
                piscine = entity.piscine,
                parking = entity.parking,
                voiturier = entity.voiturier,
                roomService = entity.roomService,
                spa = entity.spa,
                prixNuitPersonne = entity.prixNuitPersonne,
                capacite = entity.capacite,
                longitude = entity.longitude,
                latitude = entity.latitude,
                rue = entity.rue,
                numero = entity.numero,
                codePostal = entity.codePostal,
                pays = entity.pays,
                dateAjout = entity.dateAjout,
                idCategorie = entity.idCategorie,
                idProprietaire = entity.idProprietaire
            };
        }
        #endregion

        #region Proprietaire 

        public static Proprietaire ToBLL(this DO.Proprietaire entity)
        {
            if (entity is null) return null;
            return new Proprietaire()
            {
                //QUID ICI FAUT-IL VRAIMENT CREER UN PROPRIETAIRE BLL ? OU UN CLIENT BLL ? 
                idClient = entity.idProprietaire,
                nom = entity.nom,
                prenom= entity.prenom, 
                email= entity.email,    
                password= entity.password,
                telephone= entity.telephone,
                pays= entity.pays
            };
        }

        public static DO.Proprietaire ToDAL(this BO.Proprietaire entity)
        {
            if (entity is null) return null;
            return new DO.Proprietaire()
            {
                idProprietaire = entity.idClient,
                nom = entity.nom,
                prenom = entity.prenom,
                email = entity.email,
                password = entity.password,
                telephone = entity.telephone,
                pays = entity.pays
            };
        }
        #endregion

        #region Categorie 
        public static BO.Categorie ToBLL (this DO.Categorie entity)
        {
            if (entity is null) return null;
            return new BO.Categorie()
            {
                idCategorie = entity.idCategorie,
                nom = entity.nom
            }; 
        }
        #endregion
    }
}
