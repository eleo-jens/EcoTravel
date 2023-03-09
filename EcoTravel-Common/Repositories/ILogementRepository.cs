using EcoTravel_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_Common.Repositories
{
    public interface ILogementRepository<TEntity, TId>: IRepository<TEntity, TId> where TEntity : ILogement
    {
        IEnumerable<TEntity> GetByProprietaire(int idProprietaire);
        //IEnumerable<TEntity> GetByType(int idType);
    }
}
