using System;
using BO = EcoTravel_BLL.Entities;
using DO = EcoTravel_DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
