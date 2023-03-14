using EcoTravel_BLL.Entities;
using EcoTravel_MVC.Models.ModelViews.Categorie;
using EcoTravel_MVC.Models.ModelViews.Client;
using EcoTravel_MVC.Models.ModelViews.Logement;
using EcoTravel_MVC.Models.ModelViews.Proprietaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_MVC.Handlers
{
    public static class Mapper
    {
        #region Client 

        public static ClientDetails ToDetails(this Client entity)
        {
            if (entity is null) return null;
            return new ClientDetails()
            {
                idClient = entity.idClient,
                prenom = entity.prenom,
                nom = entity.nom,
                pays = entity.pays,
                email = entity.email,
                telephone = entity.telephone
            };
        }

        public static Client ToBLL(this ClientCreateForm entity)
        {
            if (entity is null) return null;
            return new Client()
            {
                idClient = default(int),
                prenom = entity.prenom,
                nom = entity.nom,
                pays = entity.pays,
                email = entity.email,
                telephone = entity.telephone,
                password = entity.password
            };
        }
        #endregion

        #region Logement

        public static Logement ToBLL(this LogementCreateForm entity)
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
                //dateAjout = entity.dateAjout,
                idCategorie = entity.idCategorie,
                idProprietaire = entity.idProprietaire
            };
        }

        public static LogementDetails ToDetails(this Logement entity)
        {
            if (entity is null) return null;
            return new LogementDetails()
            {
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
                idCategorie = entity.idCategorie, 
                idProprietaire = entity.idProprietaire
            };
        }

        public static LogementListItems ToListItem(this Logement entity)
        {
            if (entity is null) return null;
            return new LogementListItems()
            {
                idLogement = entity.idLogement,
                nom = entity.nom, 
                prixNuitPersonne = entity.prixNuitPersonne,
                capacite = entity.capacite,
                descriptionCourte = entity.descriptionCourte,
                idProprietaire = entity.idProprietaire,
                idCategorie = entity.idCategorie
            };
        }
        #endregion

        #region Categorie
        public static CategorieDetails ToDetails(this Categorie entity)
        {
            if (entity is null) return null;
            return new CategorieDetails()
            {
                idCategorie = entity.idCategorie,
                nom = entity.nom
            };
        }
        #endregion

        #region Proprietaire

        public static ProprietaireDetails ToProprietaireDetails(this Proprietaire entity)
        {
            if (entity is null) return null;
            return new ProprietaireDetails()
            {
                idClient = entity.idClient,
                nom = entity.nom,
                prenom = entity.prenom, 
                pays = entity.pays, 
                email = entity.email, 
                telephone = entity.telephone
            };
        }

        #endregion
    }
}
