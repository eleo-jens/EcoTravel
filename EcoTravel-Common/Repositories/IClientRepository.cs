using EcoTravel_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_Common.Repositories
{
    public interface IClientRepository<TEntity, TId>: IInsertRepository<TEntity, TId> where TEntity : IClient
    {
        TEntity Get(TId id);
    }
}
