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
    }
}
