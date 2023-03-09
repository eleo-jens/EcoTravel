using EcoTravel_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_Common.Repositories
{
    public interface IProprietaireRepository<TEntity, TId> : IClientRepository<TEntity, TId> where TEntity : IProprietaire
    {
    }
}
