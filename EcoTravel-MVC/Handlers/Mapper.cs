using EcoTravel_BLL.Entities;
using EcoTravel_MVC.Models.ModelViews.Client;
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
    }
}
