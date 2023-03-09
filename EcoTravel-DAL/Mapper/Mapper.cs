using EcoTravel_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_DAL.Mapper
{
    static class Mapper
    {
        #region Client 

        public static Client ToClient(this IDataRecord record)
        {
            if (record is null) return null;
            return new Client()
            {
                idClient = (int)record[nameof(Client.idClient)],
                nom = (string)record[nameof(Client.nom)],
                prenom = (string)record[nameof(Client.prenom)],
                email = (string)record[nameof(Client.email)],
                pays = (string)record[nameof(Client.pays)],
                telephone = (string)record[nameof(Client.telephone)],
                password = "********"
            };
        }

        #endregion

        #region Proprietaire 

        public static Proprietaire ToProprietaire(this IDataRecord record)
        {
            if (record is null) return null;
            return new Proprietaire()
            {
                idProprietaire = (int)record[nameof(Proprietaire.idProprietaire)],
                nom = (string)record[nameof(Proprietaire.nom)],
                prenom = (string)record[nameof(Proprietaire.prenom)],
                email = (string)record[nameof(Proprietaire.email)],
                pays = (string)record[nameof(Proprietaire.pays)],
                telephone = (string)record[nameof(Proprietaire.telephone)],
                password = "********"
            };
        }

        #endregion

        #region Logement

        public static Logement ToLogement(this IDataRecord record)
        {
            if (record is null) return null;
            return new Logement()
            {
                idLogement = (int)record[nameof(Logement.idLogement)],
                nom = (string)record[nameof(Logement.nom)],
                descriptionCourte = (string)record[nameof(Logement.descriptionCourte)],
                descriptionLongue = (string)record[nameof(Logement.descriptionLongue)],
                nbChambres = (int)record[nameof(Logement.nbChambres)],
                nbPieces = (int)record[nameof(Logement.nbPieces)],
                nbSDB = (int)record[nameof(Logement.nbSDB)],
                nbWC = (int)record[nameof(Logement.nbWC)],
                balcon = (bool)record[nameof(Logement.balcon)],
                airco = (bool)record[nameof(Logement.airco)],
                wifi = (bool)record[nameof(Logement.wifi)],
                minibar = (bool)record[nameof(Logement.minibar)],
                animauxAdmis = (bool)record[nameof(Logement.animauxAdmis)],
                piscine = (bool)record[nameof(Logement.piscine)],
                parking = (bool)record[nameof(Logement.parking)],
                voiturier = (bool)record[nameof(Logement.voiturier)],
                roomService = (bool)record[nameof(Logement.roomService)],
                spa = (bool)record[nameof(Logement.spa)],
                prixNuitPersonne = (decimal)record[nameof(Logement.prixNuitPersonne)],
                capacite = (int)record[nameof(Logement.capacite)],
                longitude = (decimal)record[nameof(Logement.longitude)],
                latitude = (decimal)record[nameof(Logement.latitude)],
                rue = (string)record[nameof(Logement.rue)],
                numero = (string)record[nameof(Logement.numero)],
                codePostal = (string)record[nameof(Logement.codePostal)],
                pays = (string)record[nameof(Logement.codePostal)],
                dateAjout = (DateTime)record[nameof(Logement.dateAjout)],
                idType = (int)record[nameof(Logement.idType)],
                idProprietaire = (int)record[nameof(Logement.idProprietaire)]
            };
        }
        #endregion
    }
}
